"""Inventory an Onshape Part Studio FeatureScript export.

The export is machine-generated: feature ids and topological references are
mangled, but everything needed to plan a port is recoverable --
configuration inputs, the variable table, the feature list with its driving
expressions, and the solved sketch geometry that Onshape stores as the
constraint solver's initial guess.

Usage: python3 tools/fs_inventory.py reference/Eurorackv1asym.fs
"""
import base64
import re
import sys
import zlib
from collections import Counter

SOLID_FEATURES = (
    "extrude booleanBodies linearPattern fillet chamfer mirror splitPart "
    "hole transform cPlane mateConnector"
).split()


def expr(blob, key):
    """Pull the human-readable expression Onshape keeps alongside each value."""
    m = re.search(
        r'"%s" : \{ \'value\' : try\(.*?\), \'expression\' : "((?:[^"\\]|\\.)*)" \}' % key,
        blob,
    )
    return m.group(1) if m else None


def decompress(q):
    """qCompressed payloads are either plain or zlib+base64 ('&<hexlen>$<b64>')."""
    if not q.startswith("&"):
        return q
    try:
        return zlib.decompress(base64.b64decode(q.split("$", 1)[1])).decode("utf8", "replace")
    except Exception:
        return "<undecodable>"


def configuration_inputs(src):
    out = []
    for m in re.finditer(r'annotation \{ \'Name\' : "([^"]+)" \}\s*\n\s*(\w+)\(configuration\["(\w+)"\]', src):
        label, kind, key = m.groups()
        out.append((label, key, kind))
    for m in re.finditer(r'annotation \{ \'Name\' : "([^"]+)" \}\s*\n\s*configuration\["(\w+)"\] is (\w+)', src):
        out.append((m.group(1), m.group(2), "enum " + m.group(3)))
    return out


def variables(src):
    out = []
    for m in re.finditer(r'assignVariable\(context, id \+ "([^"]+)", \{(.*?)\}\);\n', src, re.S):
        fid, body = m.groups()
        name = re.search(r'"name" : "([^"]*)"', body)
        mode = re.search(r'"mode" : VariableMode\.(\w+)', body)
        out.append((name.group(1) if name else "?", mode.group(1) if mode else "?", expr(body, "value")))
    return out


def feature_meta(src):
    """Each feature is emitted as `features.<id> = function(id) { ... if (<guard>) {...} }`.

    The guard is `true` for a live feature, `false` for one suppressed in this
    configuration, or a switch over a configuration enum.
    """
    out, cur, guard, name = {}, None, None, None
    for line in src.split("\n"):
        m = re.match(r"\s*features\.(\w+) = function\(id\)", line)
        if m:
            if cur:
                out[cur] = (guard, name)
            cur, guard, name = m.group(1), None, None
            continue
        if cur and guard is None:
            m = re.match(r"\s*if \((.*)\)\s*$", line)
            if m:
                guard = m.group(1)
        if cur and name is None:
            m = re.search(r'annotation \{ "Feature Name" : "(.*?)" \}', line)
            if m:
                name = m.group(1)
    if cur:
        out[cur] = (guard, name)
    return out


def features(src):
    out = []
    for lineno, line in enumerate(src.split("\n"), 1):
        m = re.match(r"\s*(%s)\(context, id \+ \"([^\"]+)\", \{(.*)" % "|".join(SOLID_FEATURES), line)
        if not m:
            continue
        kind, fid, body = m.groups()
        det = {}
        for k in ("operationType", "bodyType", "endBound", "patternType", "filletType", "chamferType", "splitType", "transformType"):
            mm = re.search(r'"%s" : (\w+\.\w+)' % k, body)
            if mm:
                det[k] = mm.group(1).split(".", 1)[1]
        for k in ("depth", "distance", "radius", "width", "instanceCount", "holeDiameterV3", "holeDepthV3"):
            e = expr(body, k)
            if e:
                det[k] = e
        ents = re.search(r'"entities" : qUnion\(\[([^\]]*)\]\)', body)
        if ents and ents.group(1).strip():
            det["nEntities"] = len(ents.group(1).split(","))
        out.append((lineno, kind, fid, det))
    return out


def suppressed(src):
    """`if (false)` wrappers are features suppressed in the exported configuration."""
    return src.count("\n                if (false)\n")


def sketches(src):
    """Solved geometry: lines are [px, py, dx, dy, tStart, tEnd]; points are [x, y]."""
    out = {}
    for m in re.finditer(r"const initialGuess(\w+) = \{(.*?)\};", src, re.S):
        fid, body = m.groups()
        ents = {}
        for e in re.finditer(r'"([^"]+)" : \[([^\]]*)\]', body):
            v = [float(x) for x in e.group(2).split(",")]
            if len(v) == 6:
                px, py, dx, dy, t0, t1 = v
                ents[e.group(1)] = (
                    "line",
                    ((px + dx * t0) * 1000, (py + dy * t0) * 1000),
                    ((px + dx * t1) * 1000, (py + dy * t1) * 1000),
                )
            elif len(v) == 2:
                ents[e.group(1)] = ("point", (v[0] * 1000, v[1] * 1000))
        out[fid] = ents
    return out


def sketch_planes(src):
    qmap = dict(re.findall(r'(\w+)_query=qCompressed\(1\.0,"([^"]*)"', src))
    out = {}
    for m in re.finditer(r'newSketch\(context, id \+ "([^"]+)", \{ "sketchPlane" : qUnion\(\[(\w+)_query\]\)', src):
        fid, var = m.groups()
        d = decompress(qmap.get(var, "?"))
        if "DUMMY" in d:
            plane = re.search(r"\$([A-Za-z]+plane)Op", d)
            out[fid] = ("default plane", plane.group(1) if plane else "?")
        else:
            origin = re.search(r"\$IdA1S[0-9a-f.]+\$(F\w+?)wireOp", d)
            out[fid] = ("face traced to sketch", origin.group(1) if origin else "?")
    return out


DIM_TYPES = "LENGTH|DISTANCE|DIAMETER|OFFSET"


def dead_features(src, meta, qmap):
    """Features that contribute nothing to this configuration.

    A feature guarded by `if (false)` is suppressed outright. Anything
    referencing its geometry then fails too -- silently, because the export
    wraps every feature call in `try(...)`. So suppression propagates.
    """
    bodies, cur = {}, None
    for line in src.split("\n"):
        m = re.match(r"\s*features\.(\w+) = function\(id\)", line)
        if m:
            cur = m.group(1)
            bodies[cur] = []
            continue
        if cur:
            bodies[cur].append(line)

    def referenced(fid):
        refs = set()
        for var in re.findall(r"(\w+)_query", "\n".join(bodies[fid])):
            q = qmap.get(var, "")
            refs |= set(re.findall(r"\$IdA1S[0-9a-f.]+\$(F[A-Za-z0-9_]+?)(?:wireOp|Op|$)", decompress(q)))
            refs |= set(re.findall(r'qSketchRegion\(id \+ "([^"]+)"', q))
        return refs

    dead = {f for f, (guard, _) in meta.items() if guard == "false"}
    while True:
        grown = {f for f in bodies if f not in dead and referenced(f) & dead}
        if not grown:
            return dead
        dead |= grown


def query_map(src):
    qmap = dict(re.findall(r'(\w+)_query=qCompressed\(1\.0,"([^"]*)"', src))
    qmap.update(dict(re.findall(r"(\w+)_query = (qSketchRegion\([^)]*\))", src)))
    return qmap


def dimensions(src):
    """Driving dimensions and their expressions.

    A handful carry no expression: the 5 OFFSET constraints take their distance
    from the offset sketch tool, and 2 LENGTH constraints store a bare value.
    """
    counts, total, bare = Counter(), 0, 0
    for m in re.finditer(
        r'skConstraint\(sketch, "[^"]*", \{ "constraintType" : ConstraintType\.(%s)(.*)' % DIM_TYPES,
        src,
    ):
        total += 1
        e = re.search(r"'expression' : \"((?:[^\"\\\\]|\\\\.)*)\"", m.group(2))
        if e:
            counts[e.group(1)] += 1
        else:
            bare += 1
    return counts, total, bare


def main(path):
    src = open(path).read()

    print("== configuration inputs ==")
    for label, key, kind in configuration_inputs(src):
        print(f"  {label:16s} {key:24s} {kind}")

    print("\n== variables ==")
    for name, mode, value in variables(src):
        print(f"  {name:24s} {mode:9s} = {value}")

    meta = feature_meta(src)

    print("\n== sketches ==")
    geo = sketches(src)
    for fid, (kind, ref) in sketch_planes(src).items():
        n = len(geo.get(fid, {}))
        print(f"  {fid:26s} {str(meta.get(fid, (None, '?'))[1]):22s} {n:3d} entities   "
              f"plane: {kind} ({ref})")

    print("\n== solid features ==")
    for lineno, kind, fid, det in features(src):
        d = " ".join(f"{k}={v}" for k, v in det.items())
        print(f"  L{lineno:<5d} {kind:15s} {str(meta.get(fid, (None, '?'))[1]):22s} {d}")

    print("\n== conditional / suppressed features ==")
    for fid, (guard, name) in meta.items():
        if guard != "true":
            print(f"  {str(name):22s} {fid:26s} guard: {guard[:110]}")

    dead = dead_features(src, meta, query_map(src))
    print(f"\n== features contributing nothing to this configuration: {len(dead)} ==")
    for fid in meta:
        if fid in dead:
            why = "suppressed" if meta[fid][0] == "false" else "depends on a suppressed feature"
            print(f"  {str(meta[fid][1]):22s} {fid:26s} {why}")

    print("\n== sketch constraints ==")
    for k, v in Counter(re.findall(r"ConstraintType\.(\w+)", src)).most_common():
        print(f"  {v:4d}  {k}")

    counts, total, bare = dimensions(src)
    print(f"\n== driving dimensions: {total} ({bare} carry no expression) ==")
    for k, v in counts.most_common():
        print(f"  {v:3d}  {k}")

    qs = re.findall(r'qCompressed\(1\.0,"([^"]*)"', src)
    print(f"\n== topological references: {len(qs)} qCompressed queries "
          f"({sum(1 for q in qs if q.startswith('&'))} zlib-compressed) ==")


if __name__ == "__main__":
    main(sys.argv[1] if len(sys.argv) > 1 else "reference/Eurorackv1asym.fs")
