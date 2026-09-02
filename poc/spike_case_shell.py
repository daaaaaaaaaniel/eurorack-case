"""Feasibility spike -- NOT the port.

Exercises the three mechanics that have no direct CadQuery equivalent, to
confirm each has a workable substitute before committing to a full port:

  1. a slanted rectilinear profile written as explicit coordinates
     (substitute for Onshape's constraint solver / skSolve)
  2. an extrude length driven by a named parameter
     (substitute for FeatureScript's lookup() variable table)
  3. fillet / chamfer applied to a *subset* of edges chosen geometrically
     (substitute for the qCompressed topological-naming references, which are
     the only genuinely non-portable construct in the export)

The profile dimensions come from the solved sketch geometry in
reference/Eurorackv1asym.fs; the shape is a stand-in for the real asymmetric
case wall, not a faithful reproduction of it.

Run: python3 poc/spike_case_shell.py
"""
import cadquery as cq

HP = 5.08
HP_COUNT = 26
CASE_FRONT_HEIGHT = 62.4      # solved front wall height, default configuration
CASE_REAR_HEIGHT = 18.15      # solved rear wall height, default configuration
CASE_BOTTOM_THICKNESS = 4.0
PANEL_SPAN = 128.5            # solved rail-to-rail span, default configuration
UPPER_ROUND = 2.0
UPPER_CHAMFER = 2.0

WIDTH = HP_COUNT * HP


def case_shell(top_lips="round"):
    """Wedge-shaped shell with a configurable top lip treatment."""
    outer = [
        (0.0, 0.0),
        (PANEL_SPAN, 0.0),
        (PANEL_SPAN, -CASE_FRONT_HEIGHT),
        (0.0, -CASE_REAR_HEIGHT),
    ]
    t = CASE_BOTTOM_THICKNESS
    cavity = [
        (t, -t),
        (PANEL_SPAN - t, -t),
        (PANEL_SPAN - t, -CASE_FRONT_HEIGHT + t),
        (t, -CASE_REAR_HEIGHT + t),
    ]

    body = cq.Workplane("XZ").polyline(outer).close().extrude(WIDTH)
    void = (
        cq.Workplane("XZ")
        .polyline(cavity)
        .close()
        .extrude(WIDTH - 2 * t)
        .translate((0, -t, 0))
    )
    body = body.cut(void)

    # The part the port actually has to solve: Onshape names these edges by
    # topological history, CadQuery has to find them by where they are.
    lip_edges = body.edges("|Y").edges(">Z")
    if lip_edges.size() != 2:
        raise AssertionError(f"expected 2 top lip edges, selector found {lip_edges.size()}")

    if top_lips == "round":
        body = body.edges("|Y").edges(">Z").fillet(UPPER_ROUND)
    elif top_lips == "chamfer":
        body = body.edges("|Y").edges(">Z").chamfer(UPPER_CHAMFER)
    elif top_lips != "sharp":
        raise ValueError(top_lips)
    return body


if __name__ == "__main__":
    for mode in ("sharp", "round", "chamfer"):
        solid = case_shell(mode).val()
        bb = solid.BoundingBox()
        print(
            f"{mode:8s} valid={solid.isValid()} "
            f"volume={solid.Volume() / 1000:7.2f} cm3 "
            f"faces={len(solid.Faces()):3d} edges={len(solid.Edges()):3d} "
            f"bbox={bb.xlen:.2f} x {bb.ylen:.2f} x {bb.zlen:.2f} mm"
        )
    cq.exporters.export(case_shell("round"), "/tmp/spike_case_shell.step")
    print("STEP export OK -> /tmp/spike_case_shell.step")
