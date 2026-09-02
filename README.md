# eurorack-case

Analysis of an Onshape Part Studio (`Eurorack v1 asym` — a parametric asymmetric
Eurorack case) with a view to re-implementing it in [CadQuery](https://cadquery.readthedocs.io).

- [`docs/port-feasibility.md`](docs/port-feasibility.md) — the assessment: what
  ports cleanly, what has to be rebuilt, suggested approach, cost and risk.
- [`docs/inventory.txt`](docs/inventory.txt) — generated feature/variable/sketch
  inventory of the export.
- [`tools/fs_inventory.py`](tools/fs_inventory.py) — the extractor that produces it.
- [`poc/spike_case_shell.py`](poc/spike_case_shell.py) — a spike exercising the
  three constructs that have no direct CadQuery equivalent. Not the port.
- [`reference/Eurorackv1asym.fs`](reference/Eurorackv1asym.fs) — the source
  FeatureScript export.

```
pip install cadquery
python3 tools/fs_inventory.py reference/Eurorackv1asym.fs
python3 poc/spike_case_shell.py
```
