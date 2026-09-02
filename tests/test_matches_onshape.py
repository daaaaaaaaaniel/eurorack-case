"""The port against the parts Onshape exported from the source Part Studios.

reference/onshape/ holds STEP exports of both variants at the default
configuration (26 HP, 30/30 mm, round 1 mm lips). Frames differ, so compare
what is frame-independent: volume, face count, and sorted bounding-box
extents.
"""
from pathlib import Path

import cadquery as cq
import pytest

from eurorack_case import CaseParams, case, end_cap

REF = Path(__file__).resolve().parents[1] / "reference" / "onshape"
SYM = CaseParams()
ASYM = CaseParams(left_wall=True)

CASES = [
    ("sym-case.step", lambda: case(SYM)),
    ("sym-endcap-left.step", lambda: end_cap(SYM, "left")),
    ("sym-endcap-right.step", lambda: end_cap(SYM, "right")),
    ("asym-case.step", lambda: case(ASYM)),
    ("asym-endcap.step", lambda: end_cap(ASYM, "right")),
]


def signature(solid):
    bb = solid.BoundingBox()
    return solid.Volume(), len(solid.Faces()), sorted([bb.xlen, bb.ylen, bb.zlen])


@pytest.mark.parametrize("filename,build", CASES, ids=[c[0] for c in CASES])
def test_part_matches_onshape_export(filename, build):
    vol, faces, extents = signature(build().val())
    ref_vol, ref_faces, ref_extents = signature(cq.importers.importStep(str(REF / filename)).val())
    assert vol == pytest.approx(ref_vol, rel=1e-5)
    assert faces == ref_faces
    assert extents == pytest.approx(ref_extents, abs=1e-3)


def test_asym_end_is_a_wall():
    with pytest.raises(ValueError):
        end_cap(ASYM, "left")
    shell = case(ASYM).val()
    assert shell.BoundingBox().xmin == pytest.approx(-ASYM.end_cap_thickness)
