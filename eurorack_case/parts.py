"""Parts of the asymmetric Eurorack case.

Frame: X runs along the rails (0 .. width), Y runs front (-) to rear (+) and
is centred on the panel, Z is up with the top of the walls at Z = 0. A module
panel sits in the 2 mm recess between Z = -2 and Z = 0.

Parts:
  case()        the shell -- sloped floor, front/rear walls, T-slot rails,
                open at both ends, screw holes for the end caps
  end_cap()     4 mm plate closing one end, with a 5 mm tab that plugs into
                the shell and carries M3 nut traps
  blank_panel() a blank module panel, to check the rail spacing
"""
from math import hypot

import cadquery as cq

from .params import HP, CaseParams

EPS = 1e-3


class Floor:
    """The sloped bottom plate, as the line joining the two wall feet."""

    def __init__(self, p: CaseParams):
        self.y0, self.z0 = -p.outer_half, -p.front_height
        self.y1, self.z1 = p.outer_half, -p.rear_height
        dy, dz = self.y1 - self.y0, self.z1 - self.z0
        length = hypot(dy, dz)
        self.slope = dz / dy
        self.sec = length / dy                 # 1 / cos(tilt)
        self.inward = cq.Vector(0, -dz / length, dy / length)

    def z_outer(self, y: float) -> float:
        return self.z0 + (y - self.y0) * self.slope

    def z_at(self, y: float, offset: float) -> float:
        """Z of the line `offset` mm inside the outer floor surface, at Y = y."""
        return self.z_outer(y) + offset * self.sec

    def outer_plane(self) -> cq.Plane:
        """Workplane on the outside of the floor. Local x = X, normal points out."""
        return cq.Plane(
            origin=(0, 0, self.z_outer(0)),
            xDir=(1, 0, 0),
            normal=-self.inward,
        )


def front_plane(p: CaseParams) -> cq.Plane:
    return cq.Plane(origin=(0, -p.outer_half, 0), xDir=(1, 0, 0), normal=(0, -1, 0))


def rear_plane(p: CaseParams) -> cq.Plane:
    return cq.Plane(origin=(0, p.outer_half, 0), xDir=(1, 0, 0), normal=(0, 1, 0))


def _profile(points, length: float, x0: float = 0.0) -> cq.Workplane:
    """Extrude a closed YZ polygon from X = x0 by `length` along +X."""
    wp = cq.Workplane("YZ", origin=(x0, 0, 0))
    return wp.polyline(points).close().extrude(length)


def long_edges(body: cq.Workplane, yz_points, tol: float = 0.05) -> cq.Workplane:
    """Edges parallel to X whose centre lies at one of the given (Y, Z) points.

    This replaces Onshape's history-based edge references: the lip edges are
    known by where they are, so select them by where they are.
    """
    wanted, hit = [], set()
    for e in body.edges("|X").vals():
        c = e.Center()
        for i, (y, z) in enumerate(yz_points):
            if abs(c.y - y) < tol and abs(c.z - z) < tol:
                wanted.append(e)
                hit.add(i)
    if len(hit) != len(yz_points):
        raise ValueError(f"expected lip edges at {len(yz_points)} positions, found {len(hit)}")
    return body.newObject(wanted)


def apply_lips(body: cq.Workplane, p: CaseParams, fl: Floor) -> cq.Workplane:
    """Round / chamfer / leave the four long outer edges, per the configuration."""
    yo = p.outer_half
    top = [(-yo, 0.0), (yo, 0.0)]
    bottom = [(-yo, -p.front_height), (yo, -p.rear_height)]
    for style, size_round, size_chamfer, edges in (
        (p.top_lips, p.upper_round, p.upper_chamfer, top),
        (p.bottom_lips, p.lower_round, p.lower_chamfer, bottom),
    ):
        if style == "round":
            body = long_edges(body, edges).fillet(size_round)
        elif style == "chamfer":
            body = long_edges(body, edges).chamfer(size_chamfer)
    return body


# --------------------------------------------------------------------------
# screws that hold the end caps on
# --------------------------------------------------------------------------

def wall_hole_zs(p: CaseParams, fl: Floor, height: float, y_leg_inner: float):
    """Z of the screws through a wall of the given outer height.

    The source puts the first screw at mid-height and patterns the rest at
    `wall_hole_spacing`. Keep every position whose nut trap fits in the tab's
    leg -- between the underside of the rail and the tab's floor -- and whose
    counterbore stays on the wall.
    """
    half_pocket = p.nut_pocket_width / 2
    half_cb = p.bolt_counterbore_diam / 2
    leg_top = p.rail_bottom
    leg_floor = fl.z_at(y_leg_inner, p.bottom_thickness + p.tab_clearance + p.end_cap_tab_thickness)
    zs = []
    for k in range(-8, 9):
        z = -height / 2 + k * p.wall_hole_spacing
        if z + half_pocket > leg_top + EPS or z - half_pocket < leg_floor - EPS:
            continue
        if z + half_cb > 0 or z - half_cb < -height:
            continue
        zs.append(z)
    return sorted(zs)


def _screw_set(plane: cq.Plane, world_points, p: CaseParams, into: float) -> cq.Workplane:
    """Counterbore + through hole + nut trap for screws entering at `world_points`.

    `into` is the distance from the outer surface to the tab's inner face,
    i.e. where the nut trap opens.
    """
    pts = [plane.toLocalCoords(cq.Vector(*w)) for w in world_points]
    pts = [(v.x, v.y) for v in pts]
    wp = cq.Workplane(plane)
    counterbore = wp.pushPoints(pts).circle(p.bolt_counterbore_diam / 2).extrude(-p.bolt_counterbore_depth)
    through = wp.pushPoints(pts).circle(p.bolt_through_diam / 2).extrude(-(into + 1.0))
    pocket = (
        wp.workplane(offset=-into)
        .pushPoints(pts)
        .rect(p.nut_pocket_width, p.nut_pocket_width)
        .extrude(p.rail_nut_depth)
    )
    return counterbore.union(through).union(pocket)


def screw_cutters(p: CaseParams, fl: Floor, x: float) -> cq.Workplane:
    """Everything to subtract for the screws at one end of the case (axis at X = x)."""
    yi, yo = p.inner_half, p.outer_half
    tt, c = p.end_cap_tab_thickness, p.tab_clearance
    into = p.wall_thickness + c + tt

    # floor: three screws spaced along the tilted surface, centred on Y = 0
    fplane = fl.outer_plane()
    floor_pts = [(x, s) for s in (-p.bottom_hole_spacing, 0.0, p.bottom_hole_spacing)]
    floor_pts = [fplane.toWorldCoords((lx, ly)).toTuple() for lx, ly in floor_pts]
    cutters = _screw_set(fplane, floor_pts, p, into)

    # walls
    for plane, height, y_out in (
        (front_plane(p), p.front_height, -yo),
        (rear_plane(p), p.rear_height, yo),
    ):
        y_leg_inner = (yi - c - tt) * (1 if y_out > 0 else -1)
        zs = wall_hole_zs(p, fl, height, y_leg_inner)
        if zs:
            pts = [(x, y_out, z) for z in zs]
            cutters = cutters.union(_screw_set(plane, pts, p, into))
    return cutters


def all_screw_cutters(p: CaseParams, fl: Floor) -> cq.Workplane:
    """Screw sets for every end that takes a removable cap."""
    right = screw_cutters(p, fl, p.width - p.bottom_hole_inset)
    if "left" in p.closed_ends:
        return right
    return screw_cutters(p, fl, p.bottom_hole_inset).union(right)


# --------------------------------------------------------------------------
# parts
# --------------------------------------------------------------------------

def shell_profile(p: CaseParams, fl: Floor):
    yi, yo = p.inner_half, p.outer_half
    t = p.bottom_thickness
    return [
        (-yo, 0.0), (-yo, -p.front_height), (yo, -p.rear_height), (yo, 0.0),
        (yi, 0.0), (yi, fl.z_at(yi, t)), (-yi, fl.z_at(-yi, t)), (-yi, 0.0),
    ]


def case(p: CaseParams = CaseParams()) -> cq.Workplane:
    fl = Floor(p)
    w = p.width
    body = _profile(shell_profile(p, fl), w)

    # T-slot rails along both inner walls, under the panel recess
    yi = p.inner_half
    rail_cz = (p.rail_top + p.rail_bottom) / 2
    slot_top = p.rail_top + 1.0                      # break cleanly into the recess
    slot_bottom = p.rail_top - p.rail_bolt_depth
    nut_top = p.rail_top - p.rail_nut_depth
    nut_bottom = nut_top - p.rail_nut_thickness
    for s in (1, -1):
        rail = (
            cq.Workplane("YZ")
            .center(s * (yi - p.rail_depth / 2), rail_cz)
            .rect(p.rail_depth, p.rail_height)
            .extrude(w)
        )
        body = body.union(rail)
        axis = s * (yi - p.rail_inset)
        bolt_slot = (
            cq.Workplane("YZ")
            .center(axis, (slot_top + slot_bottom) / 2)
            .rect(p.rail_bolt_width, slot_top - slot_bottom)
            .extrude(w)
        )
        nut_slot = (
            cq.Workplane("YZ")
            .center(axis, (nut_top + nut_bottom) / 2)
            .rect(p.rail_nut_slot_width, nut_top - nut_bottom)
            .extrude(w)
        )
        body = body.cut(bolt_slot).cut(nut_slot)

    if p.left_wall:
        # the "asym" variant: a plate with the outer profile closes X = 0 and the lips
        # run along it uninterrupted. Unlike a cap, its outside face is not edge-broken.
        wall = _profile(end_plate_profile(p), p.end_cap_thickness, x0=-p.end_cap_thickness)
        body = body.union(wall)

    body = apply_lips(body, p, fl)
    return body.cut(all_screw_cutters(p, fl))


def end_plate_profile(p: CaseParams):
    yo = p.outer_half
    return [(-yo, 0.0), (-yo, -p.front_height), (yo, -p.rear_height), (yo, 0.0)]


def tab_profile(p: CaseParams, fl: Floor):
    """U-shaped band lining the cavity below the rails."""
    c, tt, bt = p.tab_clearance, p.end_cap_tab_thickness, p.bottom_thickness
    yo_ = p.inner_half - c            # outside of the tab
    yi_ = yo_ - tt                    # inside of the tab
    top = p.rail_bottom - c
    return [
        (-yo_, top), (-yo_, fl.z_at(-yo_, bt + c)), (yo_, fl.z_at(yo_, bt + c)), (yo_, top),
        (yi_, top), (yi_, fl.z_at(yi_, bt + c + tt)), (-yi_, fl.z_at(-yi_, bt + c + tt)), (-yi_, top),
    ]


def end_cap(p: CaseParams = CaseParams(), end: str = "left") -> cq.Workplane:
    """End cap in its assembled position. `left` closes X = 0, `right` closes X = width."""
    if end in p.closed_ends:
        raise ValueError(f"the {end} end is an integral wall in this configuration")
    fl = Floor(p)
    plate = _profile(end_plate_profile(p), p.end_cap_thickness, x0=-p.end_cap_thickness)
    plate = plate.faces("<X").chamfer(p.end_cap_face_chamfer)
    plate = apply_lips(plate, p, fl)
    tab = _profile(tab_profile(p, fl), p.end_cap_tab_depth)
    cap = plate.union(tab).cut(screw_cutters(p, fl, p.bottom_hole_inset))
    if end == "right":
        cap = cap.mirror("YZ", basePointVector=(p.width / 2, 0, 0))
    elif end != "left":
        raise ValueError(end)
    return cap


def blank_panel(p: CaseParams = CaseParams(), hp: int = 6, x0: float = 0.0) -> cq.Workplane:
    """A blank module panel `hp` wide, sitting in the recess from X = x0."""
    w = hp * HP
    yi = p.inner_half
    panel = (
        cq.Workplane("XY", origin=(x0, 0, 0))
        .center(w / 2, 0)
        .rect(w, p.panel_height)
        .extrude(-p.panel_thickness)
    )
    xs = (x0 + p.panel_hole_side_inset, x0 + w - p.panel_hole_side_inset)
    ys = (-(yi - p.panel_hole_edge_inset), yi - p.panel_hole_edge_inset)
    holes = (
        cq.Workplane("XY")
        .pushPoints([(x, y) for x in xs for y in ys])
        .circle(p.panel_hole_diam / 2)
        .extrude(-p.panel_thickness)
    )
    return panel.cut(holes)


def assembly(p: CaseParams = CaseParams(), panel_hp: int = 6) -> cq.Assembly:
    a = cq.Assembly(name="eurorack_case")
    a.add(case(p), name="case", color=cq.Color(0.55, 0.55, 0.6))
    for end in ("left", "right"):
        if end not in p.closed_ends:
            a.add(end_cap(p, end), name=f"end_cap_{end}", color=cq.Color(0.8, 0.5, 0.2))
    a.add(blank_panel(p, panel_hp), name="blank_panel", color=cq.Color(0.85, 0.85, 0.85))
    return a
