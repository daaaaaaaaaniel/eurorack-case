"""Build the case parts and export them.

    python3 build.py                       # defaults: 26 HP, 30/30 mm, round lips
    python3 build.py --hp 84 --front 30 --rear 80 --top-lips chamfer
    python3 build.py --out exports --formats step stl

Writes one file per part plus an assembly STEP into the output directory.
"""
import argparse
from pathlib import Path

import cadquery as cq

from eurorack_case import CaseParams, assembly, blank_panel, case, end_cap
from eurorack_case.params import LIP_STYLES


def parse(argv=None) -> argparse.Namespace:
    d = CaseParams()
    ap = argparse.ArgumentParser(description=__doc__, formatter_class=argparse.RawDescriptionHelpFormatter)
    ap.add_argument("--hp", type=int, default=d.hp_count, help="case width in HP")
    ap.add_argument("--front", type=float, default=d.front_height, help="front wall height, mm")
    ap.add_argument("--rear", type=float, default=d.rear_height, help="rear wall height, mm")
    ap.add_argument("--top-lips", choices=LIP_STYLES, default=d.top_lips)
    ap.add_argument("--upper-round", type=float, default=d.upper_round)
    ap.add_argument("--upper-chamfer", type=float, default=d.upper_chamfer)
    ap.add_argument("--bottom-lips", choices=LIP_STYLES, default=d.bottom_lips)
    ap.add_argument("--lower-round", type=float, default=d.lower_round)
    ap.add_argument("--lower-chamfer", type=float, default=d.lower_chamfer)
    ap.add_argument("--tab-clearance", type=float, default=d.tab_clearance,
                    help="shrink the end cap tab by this much for a printable fit")
    ap.add_argument("--panel-hp", type=int, default=6, help="width of the blank test panel")
    ap.add_argument("--out", type=Path, default=Path("output"))
    ap.add_argument("--formats", nargs="+", choices=("step", "stl"), default=["step", "stl"])
    return ap.parse_args(argv)


def params_from_args(a: argparse.Namespace) -> CaseParams:
    return CaseParams(
        hp_count=a.hp, front_height=a.front, rear_height=a.rear,
        top_lips=a.top_lips, upper_round=a.upper_round, upper_chamfer=a.upper_chamfer,
        bottom_lips=a.bottom_lips, lower_round=a.lower_round, lower_chamfer=a.lower_chamfer,
        tab_clearance=a.tab_clearance,
    )


def main(argv=None) -> None:
    a = parse(argv)
    p = params_from_args(a)
    a.out.mkdir(parents=True, exist_ok=True)

    parts = {
        "case": case(p),
        "end_cap_left": end_cap(p, "left"),
        "end_cap_right": end_cap(p, "right"),
        f"blank_panel_{a.panel_hp}hp": blank_panel(p, a.panel_hp),
    }
    for name, part in parts.items():
        solid = part.val()
        if not solid.isValid():
            raise RuntimeError(f"{name} is not a valid solid")
        for fmt in a.formats:
            path = a.out / f"{name}.{fmt}"
            cq.exporters.export(part, str(path))
        bb = solid.BoundingBox()
        print(f"{name:20s} {bb.xlen:7.2f} x {bb.ylen:7.2f} x {bb.zlen:7.2f} mm   {solid.Volume() / 1000:7.2f} cm3")

    if "step" in a.formats:
        assembly(p, a.panel_hp).export(str(a.out / "assembly.step"))
        print(f"assembly            -> {a.out / 'assembly.step'}")


if __name__ == "__main__":
    main()
