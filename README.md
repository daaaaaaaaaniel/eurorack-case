# eurorack-case

A parametric Eurorack case with a sloped floor in [CadQuery](https://cadquery.readthedocs.io),
ported from two Onshape Part Studios (`Eurorack v1 sym` / `asym`) and verified
against their STEP exports.

There is also a browser version at
<https://daaaaaaaaaniel.github.io/eurorack-case/> that builds the same case
without installing anything. [UserManual.md](UserManual.md) explains every
control on that page.

```
pip install cadquery
python3 build.py                                  # 26 HP, 30/30 mm walls, round lips
python3 build.py --hp 84 --front 30 --rear 80 --top-lips chamfer --tab-clearance 0.2
python3 build.py --variant asym                   # one end an integral wall, one cap
python3 -m pytest tests
```

`build.py` writes STEP and STL for each part, plus an assembly STEP, into
`output/`.

## Parts

- **case** — sloped-floor shell with T-slot rails under a 2 mm panel recess and
  counterbored M3 screw holes for the end caps. Open at both ends (`sym`), or
  closed at one end by an integral wall (`asym`, `left_wall=True`).
- **end_cap_left / end_cap_right** — 4 mm plate with a 5 mm tab that plugs into
  the shell and carries square M3 nut traps behind every screw.
- **blank_panel** — a blank module panel for checking the rail spacing.

## Configuration

The same nine inputs as the Onshape configuration, on `CaseParams`:
`hp_count`, `front_height`, `rear_height`, `top_lips` / `upper_round` /
`upper_chamfer`, `bottom_lips` / `lower_round` / `lower_chamfer`. Every other
design constant is a field too (`eurorack_case/params.py`), named after the
Onshape variable it came from.

```python
from eurorack_case import CaseParams, case, end_cap

p = CaseParams(hp_count=42, rear_height=60, top_lips="chamfer")
shell = case(p)
cap = end_cap(p, "left")
```

## Layout

- `eurorack_case/` — the model (`params.py`, `parts.py`)
- `build.py` — CLI exporter
- `tests/` — geometry checks: parts are valid, caps fit without clashing,
  screws pass the wall into the tab, nut traps sit behind them, lip styles and
  a parameter sweep build
- `viewer/` — a browser viewer (Three.js). `python3 viewer/make_viewer.py`
  embeds the exact meshes into `viewer/dist/eurorack-asym-case.html`; the page
  also rebuilds either variant in JavaScript when you move its sliders — profile
  extrusions with the screw holes, counterbores and nut traps cut by CSG
  (`viewer/vendor/csg.js`, MIT), within 0.01 % of the CadQuery volumes — and
  can save what it is showing as ASCII STL (published as a Claude artifact
  with the `downloads` capability; the host allows no `.stl` extension, so the
  file arrives as `.stl.txt` to be renamed)
- `docs/port-notes.md` — what maps to what, and where the port deliberately
  differs from the source (read this)
- `docs/port-feasibility.md` — the pre-port assessment
- `tools/fs_inventory.py` — inventory extractor for the Onshape export
- `reference/Eurorackv1asym.fs`, `Eurorackv1sym.fs` — the source FeatureScript
- `reference/onshape/` — Onshape's STEP exports of both variants, which
  `tests/test_matches_onshape.py` checks the port against
- `poc/` — the feasibility spike
