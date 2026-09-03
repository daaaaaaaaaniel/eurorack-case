# eurorack-case-web

The case configurator as a static web app: the model in
[replicad](https://replicad.xyz) (OpenCascade compiled to wasm, running in a
web worker), a three.js viewer, and STL / STEP export straight from the
browser. Same geometry as the CadQuery model, verified against the Onshape
exports.

```
npm install
npm run dev        # http://localhost:5173
npm test           # builds every part in Node, compares with reference/onshape/*.step
npm run typecheck
npm run build      # -> dist/ (~23 MB, of which the wasm is 23 MB raw / 7 MB gzipped)
```

## Layout

- `src/model/params.ts` — `caseParams()`: the fields of `CaseParams` in
  `eurorack_case/params.py`, camel-cased, plus the derived values.
- `src/model/parts.ts` — `caseShell()`, `endCap()`, `blankPanel()`: a
  line-for-line port of `eurorack_case/parts.py`, with replicad edge finders
  where the Python matched edges by center point.
- `src/filename.ts` — `partFileName()`: a part is named for itself and the
  parameters that shape it, so two files with one name hold one geometry.
- `src/config.ts` — `buildConfig()` / `parseConfig()`: the saved settings, and
  a reader that treats an imported file as untrusted.
- `src/oc.ts` — `initOC()`: starts the wasm kernel and hands it to replicad.
- `src/worker.ts` — the modeling worker: builds the parts on request, returns
  meshes + edge lines + volumes, and writes STL/STEP on demand — one part in
  one format as itself, anything more zipped with its configuration.
- `src/scene.ts`, `src/main.ts`, `index.html` — the viewer and its controls.
- `test/matches-onshape.test.ts` — volume (1e-5), face count and bounding
  extents against Onshape's exports for both variants, plus a parameter sweep.
- `test/config.test.ts`, `test/filename.test.ts` — the configuration round trip
  (including files that are hand-edited, from a later version, or not ours) and
  the naming rule. Both run without the kernel, in milliseconds.
- `scripts/smoke.mjs` — drives the built app in headless Chromium over the
  DevTools protocol: first build, a rebuild, the asym variant, a zip download
  read back out of its central directory, a single part, and a config import.

## Downloads

**Download** writes the parts ticked under Parts, in STL, STEP or both. One part
in one format comes down as itself; anything more is `case.zip`, which also
carries a `config.json` of the settings that produced it. **More options** holds
a single part on its own. Members are named for the part and what shapes it —
`case_26hp_30mm-front_45mm-rear.stl`, `capL_30mm-front_45mm-rear.stl`,
`panel_6hp.stl` — so the caps carry no HP, being a cross-section that does not
change with the case's width.

**Import config** reads a `config.json` back and puts every control where it was,
so a case can be reprinted, or adjusted and reprinted, months later. Only the
settings the page exposes are saved; everything else follows the current model.
An imported file is checked field by field, and anything corrected is reported.

## Limits the kernel imposes

- A top lip must be smaller than the wall thickness: the wall top is only that
  wide before it drops into the panel recess, so a larger fillet has no face to
  land on. `caseParams()` refuses it; the page's slider stops at 3.5 mm.
- The end cap's 1.5 mm outer edge break is only built when the lips are modest
  (rounds ≤ 5 mm, chamfers ≤ 2 mm). Beyond that OpenCascade does not fail — it
  returns a plausible-looking solid with a wrong volume — so `endCap()` leaves
  the break off and checks the volume of what it built against the un-cut plate
  and tab. The Onshape source has the same blend and would have the same
  trouble; its defaults (1 mm) are well inside the sound region.

## Deploying to GitHub Pages

`.github/workflows/pages.yml` builds `web/`, runs the tests, and deploys
`web/dist` on every push that touches `web/` (branches `claude/replicad-port`
and `main`), or by hand from the Actions tab. One-time setup in the repository:
**Settings → Pages → Source: GitHub Actions**. The site then lives at
`https://<user>.github.io/eurorack-case/`.

The kernel is single-threaded, so no cross-origin-isolation headers are
needed — Pages can serve it as plain static files. First visit downloads the
23 MB wasm (7 MB if the CDN gzips it); after that it is cached.

## Timings

In headless Chromium on a laptop-class CPU: kernel start ~10 s on a cold
cache, first build ~2 s, a rebuild ~1–2 s, STL or STEP export well under a
second.
