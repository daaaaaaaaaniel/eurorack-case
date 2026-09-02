import math

import cadquery as cq
import pytest

from eurorack_case import HP, CaseParams, blank_panel, case, end_cap
from eurorack_case.parts import Floor, wall_hole_zs

DEFAULT = CaseParams()


def solid(wp):
    s = wp.val()
    assert s.isValid()
    return s


def circles_on_face(part, selector):
    return [e for e in part.faces(selector).edges().vals() if e.geomType() == "CIRCLE"]


def test_case_envelope():
    s = solid(case(DEFAULT))
    bb = s.BoundingBox()
    assert bb.xlen == pytest.approx(26 * HP)
    assert bb.ylen == pytest.approx(DEFAULT.panel_height + 2 * DEFAULT.wall_thickness)
    assert bb.zlen == pytest.approx(30.0)
    assert bb.zmax == pytest.approx(0.0)


def test_rail_slot_is_where_the_panel_holes_are():
    """The panel's holes must land on the rail's bolt slot."""
    p = DEFAULT
    slot_axis = p.inner_half - p.rail_inset
    hole_axis = p.inner_half - p.panel_hole_edge_inset
    assert slot_axis == pytest.approx(hole_axis)

    # and the slot really is open at the rail top
    c = case(p)
    probe = cq.Workplane("XY").box(1, p.rail_bolt_width - 0.2, p.rail_bolt_depth - 0.2, centered=True)
    probe = probe.translate((p.width / 2, slot_axis, p.rail_top - p.rail_bolt_depth / 2 + 0.05))
    assert c.intersect(probe).val().Volume() == pytest.approx(0.0, abs=1e-6)


def test_end_caps_fit_without_clashing():
    c = case(DEFAULT)
    for end in ("left", "right"):
        cap = end_cap(DEFAULT, end)
        solid(cap)
        assert c.intersect(cap).val().Volume() == pytest.approx(0.0, abs=1e-6)
    left, right = solid(end_cap(DEFAULT, "left")), solid(end_cap(DEFAULT, "right"))
    assert left.BoundingBox().xmin == pytest.approx(-DEFAULT.end_cap_thickness)
    assert right.BoundingBox().xmax == pytest.approx(DEFAULT.width + DEFAULT.end_cap_thickness)
    assert left.Volume() == pytest.approx(right.Volume())


def test_screw_holes_go_through_shell_into_tab():
    """A pin down each screw axis must pass the wall and the tab and stop at the nut trap."""
    p = DEFAULT
    c, cap = case(p), end_cap(p, "left")
    fl = Floor(p)
    x = p.bottom_hole_inset
    # front wall screw, mid-height
    z = -p.front_height / 2
    pin = cq.Workplane("XY").box(1.0, p.wall_thickness + p.end_cap_tab_thickness + 2, 1.0)
    pin = pin.translate((x, -p.outer_half + (p.wall_thickness + p.end_cap_tab_thickness + 2) / 2 - 1, z))
    assert c.intersect(pin).val().Volume() == pytest.approx(0.0, abs=1e-6)
    assert cap.intersect(pin).val().Volume() == pytest.approx(0.0, abs=1e-6)
    # floor screw at Y = 0: pin along the floor normal
    n = fl.inward
    length = p.wall_thickness + p.end_cap_tab_thickness + 2
    pin = cq.Workplane(cq.Plane(origin=(x, 0, fl.z_outer(0) - 1), xDir=(1, 0, 0), normal=n.toTuple()))
    pin = pin.rect(1.0, 1.0).extrude(length)
    assert c.intersect(pin).val().Volume() == pytest.approx(0.0, abs=1e-6)
    assert cap.intersect(pin).val().Volume() == pytest.approx(0.0, abs=1e-6)


def test_screw_count_per_end():
    p = DEFAULT
    c = case(p)
    # three counterbore rims on the outer floor at each end
    assert len(circles_on_face(c, "<Z")) == 2 * 3
    # each with a through hole in its floor
    cb_floors = c.faces(cq.selectors.BoxSelector(
        (-1, -100, -DEFAULT.front_height - 1), (DEFAULT.width + 1, 100, -DEFAULT.front_height + DEFAULT.bolt_counterbore_depth + 0.01)
    )).faces("%PLANE").vals()
    inner_rims = [e for f in cb_floors for e in f.Edges() if e.geomType() == "CIRCLE" and abs(e.radius() - DEFAULT.bolt_through_diam / 2) < 1e-6]
    assert len(inner_rims) == 2 * 3
    # one screw per wall at 30 mm; the wall pattern only grows when it fits
    y_leg = -(p.inner_half - p.end_cap_tab_thickness)
    assert wall_hole_zs(p, Floor(p), 30.0, y_leg) == [-15.0]
    tall = CaseParams(front_height=80.0)
    assert wall_hole_zs(tall, Floor(tall), 80.0, y_leg) == [-63.0, -40.0, -17.0]
    short = CaseParams(front_height=22.0, rear_height=22.0)
    assert wall_hole_zs(short, Floor(short), 22.0, y_leg) == []
    solid(case(short))
    solid(end_cap(short))


def test_nut_trap_sits_behind_the_front_wall_screw():
    p = DEFAULT
    cap = end_cap(p, "left")
    x, z = p.bottom_hole_inset, -p.front_height / 2
    y_pocket = -(p.inner_half - p.end_cap_tab_thickness + p.rail_nut_depth / 2)   # 2 mm deep into the leg's inner face
    void = cq.Workplane("XY").box(3, 1, 3).translate((x, y_pocket, z))
    assert cap.intersect(void).val().Volume() == pytest.approx(0.0, abs=1e-6)
    # next to the pocket, still inside the tab, the leg is solid
    beside = cq.Workplane("XY").box(1, 1, 3).translate((x + p.nut_pocket_width / 2 + 0.6, y_pocket, z))
    assert cap.intersect(beside).val().Volume() == pytest.approx(3.0, rel=1e-3)


@pytest.mark.parametrize("top,bottom", [("sharp", "sharp"), ("round", "round"), ("chamfer", "chamfer"), ("round", "chamfer")])
def test_lip_styles(top, bottom):
    p = CaseParams(top_lips=top, bottom_lips=bottom, upper_round=2, lower_round=2, upper_chamfer=2, lower_chamfer=2)
    s = solid(case(p))
    sharp = solid(case(CaseParams(top_lips="sharp", bottom_lips="sharp")))
    if (top, bottom) == ("sharp", "sharp"):
        assert len(s.Faces()) == len(sharp.Faces())
    else:
        assert len(s.Faces()) > len(sharp.Faces())
        assert s.Volume() < sharp.Volume()
    solid(end_cap(p, "left"))


@pytest.mark.parametrize("kw", [
    dict(hp_count=2),
    dict(hp_count=126),
    dict(front_height=21.0, rear_height=30.0),
    dict(front_height=30.0, rear_height=150.0),
    dict(front_height=200.0, rear_height=30.0, top_lips="chamfer", bottom_lips="chamfer"),
    dict(tab_clearance=0.2),
])
def test_parameter_sweep(kw):
    p = CaseParams(**kw)
    c = case(p)
    solid(c)
    for end in ("left", "right"):
        cap = end_cap(p, end)
        solid(cap)
        assert c.intersect(cap).val().Volume() == pytest.approx(0.0, abs=1e-6)


def test_blank_panel_sits_in_the_recess():
    p = DEFAULT
    panel = solid(blank_panel(p, 6))
    bb = panel.BoundingBox()
    assert bb.xlen == pytest.approx(6 * HP)
    assert bb.ylen == pytest.approx(p.panel_height)
    assert bb.zmax == pytest.approx(0.0) and bb.zmin == pytest.approx(-p.panel_thickness)
    assert len([e for e in panel.Edges() if e.geomType() == "CIRCLE"]) == 8
    assert case(p).intersect(blank_panel(p, 6)).val().Volume() == pytest.approx(0.0, abs=1e-6)


def test_rejects_walls_too_short_for_the_tab():
    with pytest.raises(ValueError):
        CaseParams(front_height=20.0)
    with pytest.raises(ValueError):
        CaseParams(top_lips="bevel")
