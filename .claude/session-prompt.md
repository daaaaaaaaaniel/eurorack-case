# Session instructions — eurorack-case

Standing context for this project. Edit this file to change how the session behaves: the
UserPromptSubmit hook injects it on every turn, so an edit takes effect on the next prompt.

## Project

A parametric Eurorack case ported from an Onshape FeatureScript Part Studio. Two
implementations of the same geometry, both verified against Onshape's STEP exports:

- `eurorack_case/` — CadQuery (Python), branch `claude/featurescript-cadquery-port-rvy9au`.
- `web/` — replicad (TypeScript) plus a browser configurator, branch `claude/replicad-port`,
  deployed to GitHub Pages at https://daaaaaaaaaniel.github.io/eurorack-case/.

Do not modify the CadQuery model from the replicad branch. The replicad branch is for web
work only.

## Geometry frame

X runs along the rails, and the width is `hp × 5.08`. Y is centred, front negative and rear
positive. Z is up, with the wall tops at 0. Keep this frame in every part so
`docs/variables.md` and the comparison tests stay valid.

## Verified reference values

Do not re-derive these. They match `reference/onshape/*.step` to 1e-5.

| part | volume (cm³) | faces |
| --- | --- | --- |
| case, two end caps (sym) | 111.5710 | 76 |
| case, integral left wall (asym) | 128.4112 | 61 |
| end cap | 21.7197 | 53 |

## Conventions

- Run `npm test` and `node scripts/smoke.mjs` in `web/` before any push. One validated push
  beats three speculative ones.
- Never hand-edit generated files. Regenerate them with the project's own tooling.
- Push only to the designated branch, and never force-push a branch someone else may hold.
- PSU mounts belong to an old revision and are not wanted.
- Report the turn's token usage at the end of a substantial turn.
- If GitHub access is blocked, deliver the changed files in chat rather than stopping.

## Open work — web interface

- Add a total-volume line for the selected parts under "Parts".
- Consider an option to sync the top and bottom lip configurations.
- Remove the two explanatory paragraphs about rebuild behaviour and about rail spacing.
- Update the readout section and the export naming rules.
- Export a zip when several parts are selected.
- Rename the "Removable cap (sym)" and "Integral wall (asym)" options, and move that control
  to the top of the panel.
- Add a credits section.
- Show "LOADING" in the centre of the canvas during the first kernel start.
- Show drag feedback while a slider moves, so the page never looks frozen.
- Warn on mobile, or improve the small-screen layout.
- Upload reference STEP files built with other corner settings.
- Fork the model for an OpenSCAD build.
