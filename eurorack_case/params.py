"""Parameters for the asymmetric Eurorack case.

Names follow the variables in the Onshape source (reference/Eurorackv1asym.fs)
so the two can be read side by side. The first block is the Onshape
configuration (what the user sets); the rest are the design constants that
were `#variables` in the Part Studio.

Units are millimetres throughout.
"""
from dataclasses import dataclass

HP = 5.08

LIP_STYLES = ("round", "sharp", "chamfer")


@dataclass(frozen=True)
class CaseParams:
    # --- configuration inputs -------------------------------------------
    hp_count: int = 26
    front_height: float = 30.0      # Front_Height: outer height of the front wall
    rear_height: float = 30.0       # RearHeight:   outer height of the rear wall
    top_lips: str = "round"         # round | sharp | chamfer
    upper_round: float = 1.0
    upper_chamfer: float = 1.0
    bottom_lips: str = "round"
    lower_round: float = 1.0
    lower_chamfer: float = 1.0      # Lower_Lip_Bevel
    left_wall: bool = False         # True = the "asym" Part Studio: X = 0 closed by an
                                    # integral wall, one removable cap at the far end.
                                    # False = the "sym" Part Studio: open both ends, two caps.

    # --- shell ----------------------------------------------------------
    panel_height: float = 129.5     # PanelHeight: clear width between the inner walls
    panel_thickness: float = 2.0    # PanelThickness: depth of the panel recess
    wall_thickness: float = 4.0     # CaseFrontBackThickness
    bottom_thickness: float = 4.0   # CaseBottomThickness

    # --- rails (T-slot blocks under the panel recess) -------------------
    rail_depth: float = 7.798472    # drawn with a bare 7.798 in the sketch; the RailBlockDepth
                                    # variable (8 mm) is never referenced. Matches the STEP.
    rail_height: float = 10.0       # solved height of the rail block
    rail_inset: float = 3.0         # RailBlockPanelInset: bolt axis from the inner wall
    rail_bolt_width: float = 3.2    # RailBlockBoltWidth
    rail_bolt_depth: float = 8.0    # RailBlockBoltDepth
    rail_nut_width: float = 5.8     # RailBlockNutWidth: sizes the nut traps in the end cap tab
    rail_nut_slot_width: float = 5.596945   # the rail's sliding-nut slot is undimensioned in
                                    # the sketch and solved to this. Matches the STEP.
    rail_nut_thickness: float = 2.5 # RailBlockNutThickness
    rail_nut_depth: float = 2.0     # RailBlockNutDepth: nut pocket top below the rail top
    nut_clearance: float = 0.1      # pockets are cut RailBlockNutWidth - .1mm

    # --- end caps -------------------------------------------------------
    end_cap_thickness: float = 4.0  # EndCapThickness (= wall thickness in the source)
    end_cap_tab_thickness: float = 5.0   # EndCapTabThickness
    end_cap_face_chamfer: float = 1.5    # edge break around the outer face
    tab_clearance: float = 0.0      # shrink the tab for a printable fit (0 in the source)

    # --- end cap screws (M3, through the shell into the tab) ------------
    bolt_through_diam: float = 3.3      # BoltThrougDiam
    bolt_counterbore_diam: float = 6.0  # BoltCounterboreDiam
    bolt_counterbore_depth: float = 1.75  # BoltCounterboreThick
    bottom_hole_inset: float = 4.0      # BottomHoleInset: screw axis from the case end
    bottom_hole_spacing: float = 55.0   # BottomHoleSpacing
    wall_hole_spacing: float = 23.0     # RearHoleSpacing

    # --- blank test panel ----------------------------------------------
    panel_hole_diam: float = 3.2
    panel_hole_edge_inset: float = 3.0  # PanelHoleVerticalInset
    panel_hole_side_inset: float = 7.5

    def __post_init__(self):
        if self.top_lips not in LIP_STYLES or self.bottom_lips not in LIP_STYLES:
            raise ValueError(f"lip style must be one of {LIP_STYLES}")
        if self.hp_count < 2:
            raise ValueError("hp_count must be at least 2")
        minimum = self.panel_thickness + self.rail_height + self.bottom_thickness + self.end_cap_tab_thickness
        for name in ("front_height", "rear_height"):
            if getattr(self, name) < minimum:
                raise ValueError(
                    f"{name} must be at least {minimum} mm to fit the end cap tab between the rail and the floor"
                )

    # --- derived --------------------------------------------------------
    @property
    def width(self) -> float:
        """Case length along the rails."""
        return self.hp_count * HP

    @property
    def inner_half(self) -> float:
        return self.panel_height / 2

    @property
    def outer_half(self) -> float:
        return self.inner_half + self.wall_thickness

    @property
    def rail_top(self) -> float:
        return -self.panel_thickness

    @property
    def rail_bottom(self) -> float:
        return -self.panel_thickness - self.rail_height

    @property
    def nut_pocket_width(self) -> float:
        """Square nut traps in the end cap tab: RailBlockNutWidth - .1mm."""
        return self.rail_nut_width - self.nut_clearance

    @property
    def closed_ends(self):
        return ("left",) if self.left_wall else ()

    @property
    def end_cap_tab_depth(self) -> float:
        """EndCapTabDepth = #BottomHoleInset + .7 * #BoltCounterboreDiam."""
        return self.bottom_hole_inset + 0.7 * self.bolt_counterbore_diam
