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
  where the Python matched edges by centre point.
- `src/oc.ts` — `initOC()`: starts the wasm kernel and hands it to replicad.
- `src/worker.ts` — the modelling worker: builds the parts on request, returns
  meshes + edge lines + volumes, and writes STL/STEP blobs on demand.
- `src/scene.ts`, `src/main.ts`, `index.html` — the viewer and its controls.
- `test/matches-onshape.test.ts` — volume (1e-5), face count and bounding
  extents against Onshape's exports for both variants, plus a parameter sweep.
- `scripts/smoke.mjs` — drives the built app in headless Chromium over the
  DevTools protocol: first build, a rebuild, the asym variant, both exports.

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
