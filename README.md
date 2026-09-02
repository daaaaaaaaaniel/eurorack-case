# eurorack-case

A parametric asymmetric Eurorack case in [CadQuery](https://cadquery.readthedocs.io),
ported from an Onshape Part Studio (`Eurorack v1 asym`).

```
pip install cadquery
python3 build.py                                  # 26 HP, 30/30 mm walls, round lips
python3 build.py --hp 84 --front 30 --rear 80 --top-lips chamfer --tab-clearance 0.2
python3 -m pytest tests
```

`build.py` writes STEP and STL for each part, plus an assembly STEP, into
`output/`.

## Parts

- **case** — sloped-floor shell with T-slot rails under a 2 mm panel recess,
  open at both ends, counterbored M3 screw holes for the end caps.
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
- `docs/port-notes.md` — what maps to what, and where the port deliberately
  differs from the source (read this)
- `docs/port-feasibility.md` — the pre-port assessment
- `tools/fs_inventory.py` — inventory extractor for the Onshape export
- `reference/Eurorackv1asym.fs` — the source FeatureScript
- `poc/` — the feasibility spike
