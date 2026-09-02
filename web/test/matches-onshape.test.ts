/**
 * The replicad port against the parts Onshape exported from the source Part
 * Studios (reference/onshape/*.step), the same check tests/test_matches_onshape.py
 * makes for the CadQuery model. Frames differ, so compare what is
 * frame-independent: volume, face count, sorted bounding-box extents.
 */
import { readFileSync } from "node:fs";
import { resolve } from "node:path";

import { importSTEP, measureVolume, type Shape3D } from "replicad";
import { beforeAll, describe, expect, test } from "vitest";

import { initOC } from "../src/oc";
import { caseParams } from "../src/model/params";
import { blankPanel, caseShell, endCap } from "../src/model/parts";

const REF = resolve(__dirname, "../../reference/onshape");
const SYM = caseParams();
const ASYM = caseParams({ leftWall: true });

function signature(shape: Shape3D) {
  const [lo, hi] = shape.boundingBox.bounds;
  const extents = [hi[0] - lo[0], hi[1] - lo[1], hi[2] - lo[2]].sort((a, b) => a - b);
  return { volume: measureVolume(shape), faces: shape.faces.length, extents };
}

async function reference(file: string): Promise<Shape3D> {
  const bytes = readFileSync(resolve(REF, file));
  return (await importSTEP(new Blob([bytes]))) as Shape3D;
}

beforeAll(() => initOC());

describe("matches Onshape's STEP exports", () => {
  const cases: [string, () => Shape3D][] = [
    ["sym-case.step", () => caseShell(SYM)],
    ["sym-endcap-left.step", () => endCap(SYM, "left")],
    ["sym-endcap-right.step", () => endCap(SYM, "right")],
    ["asym-case.step", () => caseShell(ASYM)],
    ["asym-endcap.step", () => endCap(ASYM, "right")],
  ];
  test.each(cases)("%s", async (file, build) => {
    const mine = signature(build());
    const theirs = signature(await reference(file));
    expect(mine.volume).toBeCloseTo(theirs.volume, 2);
    expect(Math.abs(mine.volume - theirs.volume) / theirs.volume).toBeLessThan(1e-5);
    expect(mine.faces).toBe(theirs.faces);
    for (let i = 0; i < 3; i++) expect(mine.extents[i]).toBeCloseTo(theirs.extents[i], 3);
  });
});

describe("parts", () => {
  test("blank panel sits in the recess with four holes", () => {
    const panel = blankPanel(SYM, 6);
    const [lo, hi] = panel.boundingBox.bounds;
    expect(hi[0] - lo[0]).toBeCloseTo(6 * 5.08, 6);
    expect(hi[1] - lo[1]).toBeCloseTo(SYM.panelHeight, 6);
    expect(lo[2]).toBeCloseTo(-SYM.panelThickness, 6);
    expect(hi[2]).toBeCloseTo(0, 6);
    expect(measureVolume(panel)).toBeCloseTo(6 * 5.08 * 129.5 * 2 - 4 * Math.PI * 1.6 * 1.6 * 2, 3);
  });

  test("the asym left end is a wall", () => {
    expect(() => endCap(ASYM, "left")).toThrow();
    expect(caseShell(ASYM).boundingBox.bounds[0][0]).toBeCloseTo(-ASYM.endCapThickness, 6);
  });

  test.each([
    { hpCount: 2 },
    { frontHeight: 30, rearHeight: 80 },
    { frontHeight: 21, rearHeight: 30, topLips: "chamfer" as const, bottomLips: "sharp" as const },
    { tabClearance: 0.2 },
  ])("builds %o", (kw) => {
    const p = caseParams(kw);
    const shell = caseShell(p);
    expect(measureVolume(shell)).toBeGreaterThan(0);
    for (const end of ["left", "right"] as const) {
      const cap = endCap(p, end);
      expect(measureVolume(shell.intersect(cap) as Shape3D)).toBeCloseTo(0, 6);
    }
  });
});
