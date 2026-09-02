# eurorack-case-web

The case model in [replicad](https://replicad.xyz) — OpenCascade compiled to
wasm, so the same B-rep geometry as the CadQuery model can run in a browser.

```
npm install
npm test          # builds every part in Node and checks it against reference/onshape/*.step
npm run typecheck
```

- `src/model/params.ts` — `caseParams()`: the same fields as `CaseParams` in
  `eurorack_case/params.py`, camel-cased, with the derived values.
- `src/model/parts.ts` — `caseShell()`, `endCap()`, `blankPanel()`: a
  line-for-line port of `eurorack_case/parts.py`. Edge selection uses
  replicad finders where the Python used centre-point matching.
- `src/oc.ts` — `initOC()`: starts the wasm kernel and hands it to replicad.
  Call once before modelling. In Node it finds the wasm itself; in a browser
  pass `locateFile` pointing at the served `replicad_single.wasm`.
- `test/matches-onshape.test.ts` — volume (1e-5), face count and bounding
  extents against Onshape's exports for both variants, plus a parameter sweep.

Not here yet: the viewer and the GitHub Pages deployment. The CadQuery model
remains the reference implementation on the main branch.
