"""Embed the exact CadQuery meshes into the viewer page.

    python3 viewer/make_viewer.py            # writes viewer/dist/eurorack-asym-case.html

The page itself (viewer/template.html) carries a live JavaScript preview
driven by sliders; this script only supplies the exact meshes for one
configuration, so the viewer can show what build.py exports.
"""
import base64
import json
import struct
import sys
from pathlib import Path

sys.path.insert(0, str(Path(__file__).resolve().parents[1]))

from eurorack_case import CaseParams, blank_panel, case, end_cap  # noqa: E402

HERE = Path(__file__).resolve().parent


def mesh_b64(wp, tol=0.05, ang=0.2):
    verts, tris = wp.val().tessellate(tol, ang)
    pos = struct.pack(f"<{3 * len(verts)}f", *[c for v in verts for c in (v.x, v.y, v.z)])
    idx = struct.pack(f"<{3 * len(tris)}I", *[i for t in tris for i in t])
    return {
        "p": base64.b64encode(pos).decode(),
        "i": base64.b64encode(idx).decode(),
        "tris": len(tris),
    }


def main(p: CaseParams = CaseParams(), panel_hp: int = 6):
    parts = {
        "case": case(p),
        "capL": end_cap(p, "left"),
        "capR": end_cap(p, "right"),
        "panel": blank_panel(p, panel_hp),
    }
    data = {"params": {k: getattr(p, k) for k in (
        "hp_count", "front_height", "rear_height", "top_lips", "upper_round", "upper_chamfer",
        "bottom_lips", "lower_round", "lower_chamfer", "tab_clearance", "left_wall")}, "panel_hp": panel_hp, "meshes": {}}
    for name, wp in parts.items():
        data["meshes"][name] = mesh_b64(wp)
        data["meshes"][name]["volume"] = wp.val().Volume()
    html = (HERE / "template.html").read_text()
    html = html.replace("/*__EXACT_DATA__*/null", json.dumps(data))
    out = HERE / "dist" / "eurorack-asym-case.html"
    out.parent.mkdir(exist_ok=True)
    out.write_text(html)
    total = sum(m["tris"] for m in data["meshes"].values())
    print(f"{out}  {out.stat().st_size / 1e6:.2f} MB, {total} triangles")


if __name__ == "__main__":
    main()
