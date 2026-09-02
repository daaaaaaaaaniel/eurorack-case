/**
 * Every lip control across the range the page offers must build a sound shell
 * and end cap. The kernel's failure modes here are an exception (fillet with
 * nothing to land on) or, worse, a plausible shape with a wild volume; both
 * are caught by caseParams/endCap and must not reach the page.
 */
import { measureVolume } from "replicad";
import { beforeAll, describe, expect, test } from "vitest";

import { initOC } from "../src/oc";
import { caseParams, type CaseParamsInput } from "../src/model/params";
import { caseShell, endCap } from "../src/model/parts";

beforeAll(() => initOC());

const cases: CaseParamsInput[] = [
  { topLips: "round", upperRound: 0.5 },
  { topLips: "round", upperRound: 3.5 },
  { topLips: "chamfer", upperChamfer: 0.5 },
  { topLips: "chamfer", upperChamfer: 3.5 },
  { bottomLips: "round", lowerRound: 0.5 },
  { bottomLips: "round", lowerRound: 10 },
  { bottomLips: "chamfer", lowerChamfer: 0.5 },
  { bottomLips: "chamfer", lowerChamfer: 10 },
  { topLips: "sharp", bottomLips: "sharp" },
  { topLips: "chamfer", upperChamfer: 3.5, bottomLips: "chamfer", lowerChamfer: 10, rearHeight: 80 },
];

describe("lip sizes across the page's ranges", () => {
  test.each(cases)("%o", (kw) => {
    const p = caseParams(kw);
    const shellVol = measureVolume(caseShell(p));
    expect(shellVol).toBeGreaterThan(90_000);
    expect(shellVol).toBeLessThan(140_000);
    // a 30/30 cap is ~21.7 cm3; taller walls scale the plate, so bound it per height
    const scale = Math.max(p.frontHeight, p.rearHeight) / 30;
    for (const end of ["left", "right"] as const) {
      const v = measureVolume(endCap(p, end));
      expect(v).toBeGreaterThan(21_000 * 0.9);
      expect(v).toBeLessThan(22_200 * scale);
    }
  });

  test("a top lip as large as the wall is refused before the kernel sees it", () => {
    expect(() => caseParams({ upperRound: 4 })).toThrow(/wall thickness/);
    expect(() => caseParams({ topLips: "chamfer", upperChamfer: 5 })).toThrow(/wall thickness/);
  });

  test("the default cap keeps its outer edge break; a large lip drops it", () => {
    expect(endCap(caseParams(), "left").faces.length).toBe(53);
    expect(endCap(caseParams({ lowerRound: 8 }), "left").faces.length).toBe(49);
  });
});
