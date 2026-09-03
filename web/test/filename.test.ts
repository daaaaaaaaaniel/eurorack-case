/** Download names are part of the interface: keep them stable and readable. */
import { describe, expect, test } from "vitest";

import { BUNDLE_NAME, partFileName } from "../src/filename";
import { caseParams } from "../src/model/params";

describe("part names", () => {
  test("carry the part and the parameters that shape it", () => {
    const p = caseParams({ hpCount: 26, frontHeight: 30, rearHeight: 45 });
    expect(partFileName(p, "case", 6, "stl")).toBe("case_26hp_30mm-front_45mm-rear.stl");
    expect(partFileName(p, "capL", 6, "stl")).toBe("capL_30mm-front_45mm-rear.stl");
    expect(partFileName(p, "capR", 6, "step")).toBe("capR_30mm-front_45mm-rear.step");
    expect(partFileName(p, "panel", 6, "stl")).toBe("panel_6hp.stl");
  });

  test("leave out what does not shape the part", () => {
    // the caps are a cross-section: widening the case does not change them
    const narrow = caseParams({ hpCount: 26 });
    const wide = caseParams({ hpCount: 84 });
    expect(partFileName(wide, "capR", 6, "stl")).toBe(partFileName(narrow, "capR", 6, "stl"));
    expect(partFileName(wide, "case", 6, "stl")).not.toBe(partFileName(narrow, "case", 6, "stl"));
  });

  test("drop trailing zeros from fractional millimetres", () => {
    const p = caseParams({ frontHeight: 30.5, rearHeight: 30.5 });
    expect(partFileName(p, "case", 6, "stl")).toBe("case_26hp_30.5mm-front_30.5mm-rear.stl");
  });

  test("the archive is one fixed name", () => {
    expect(BUNDLE_NAME).toBe("case.zip");
  });
});
