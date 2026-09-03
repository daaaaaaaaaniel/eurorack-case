/**
 * The configuration file is the one thing here that reads input from outside,
 * so the reader has to hold up against files that are hand-edited, from another
 * version, or not ours at all.
 */
import { describe, expect, test } from "vitest";

import { buildConfig, configText, parseConfig, CONFIG_FORMAT } from "../src/config";
import { caseParams, DEFAULTS } from "../src/model/params";

const written = (over: Parameters<typeof caseParams>[0] = {}, panelHp = 6) =>
  configText(buildConfig(caseParams(over), panelHp));

describe("a configuration round trip", () => {
  test("comes back with the same settings", () => {
    const text = written({ hpCount: 84, frontHeight: 30, rearHeight: 80, topLips: "chamfer", upperChamfer: 2, leftWall: true, tabClearance: 0.2 }, 12);
    const { parameters, warnings } = parseConfig(text);
    expect(warnings).toEqual([]);
    expect(parameters).toMatchObject({
      hpCount: 84, frontHeight: 30, rearHeight: 80,
      topLips: "chamfer", upperChamfer: 2, leftWall: true, tabClearance: 0.2, blankPanelHp: 12,
    });
  });

  test("carries both lip sizes, so switching style recovers the right one", () => {
    const { parameters } = parseConfig(written({ topLips: "round", upperRound: 2.5, upperChamfer: 1.5 }));
    expect(parameters.upperRound).toBe(2.5);
    expect(parameters.upperChamfer).toBe(1.5);
  });

  test("is readable JSON with the parameters in one place", () => {
    const doc = JSON.parse(written());
    expect(doc.format).toBe(CONFIG_FORMAT);
    expect(doc.version).toBe(1);
    expect(Object.keys(doc)).toEqual(["format", "version", "generated", "source", "parameters"]);
  });
});

describe("a file we should refuse", () => {
  test.each([
    ["not JSON at all", "<html>nope</html>", /not JSON/],
    ["a bare array", "[1, 2, 3]", /single JSON object/],
    ["someone else's JSON", '{"tool":"other","parameters":{}}', /not a eurorack-case/],
  ])("%s", (_label, text, message) => {
    expect(() => parseConfig(text)).toThrow(message);
  });
});

describe("a file we should correct rather than refuse", () => {
  const load = (parameters: Record<string, unknown>) =>
    parseConfig(JSON.stringify({ format: CONFIG_FORMAT, version: 1, parameters }));

  test("a number that is not a number falls back", () => {
    const { parameters, warnings } = load({ hpCount: "big" });
    expect(parameters.hpCount).toBe(DEFAULTS.hpCount);
    expect(warnings[0]).toMatch(/hpCount is not a number/);
  });

  test.each([Infinity, NaN])("%p falls back", (value) => {
    // JSON has no Infinity or NaN, but JSON.parse is not the only way in
    expect(parseConfig(JSON.stringify({ format: CONFIG_FORMAT, parameters: { frontHeight: 30 } }))
      .parameters.frontHeight).toBe(30);
    const { parameters } = load({ frontHeight: value as number });
    expect(parameters.frontHeight).toBe(DEFAULTS.frontHeight);
  });

  test("an absurd size is clamped to what the control offers", () => {
    const { parameters, warnings } = load({ hpCount: 1e9, frontHeight: -50 });
    expect(parameters.hpCount).toBe(168);
    expect(parameters.frontHeight).toBe(21);
    expect(warnings.join(" ")).toMatch(/outside/);
  });

  test("a lip style we do not know falls back", () => {
    const { parameters, warnings } = load({ topLips: "banana" });
    expect(parameters.topLips).toBe(DEFAULTS.topLips);
    expect(warnings[0]).toMatch(/not a lip style/);
  });

  test("unknown keys are ignored rather than reaching the model", () => {
    const { parameters } = load({ hpCount: 30, __proto__: { polluted: true }, wallThickness: 0 });
    expect(parameters.hpCount).toBe(30);
    expect("wallThickness" in parameters).toBe(false);
    expect(({} as Record<string, unknown>).polluted).toBeUndefined();
  });

  test("a missing file body just gives the defaults", () => {
    const { parameters } = parseConfig(JSON.stringify({ format: CONFIG_FORMAT }));
    expect(parameters.hpCount).toBe(DEFAULTS.hpCount);
    expect(parameters.blankPanelHp).toBe(6);
  });

  test("a panel wider than the case is brought back in", () => {
    expect(load({ hpCount: 4, blankPanelHp: 40 }).parameters.blankPanelHp).toBe(4);
  });

  test("a newer version is read, with a word about it", () => {
    const { warnings } = parseConfig(JSON.stringify({ format: CONFIG_FORMAT, version: 99, parameters: {} }));
    expect(warnings[0]).toMatch(/version 99/);
  });

  test("everything it produces still builds", () => {
    const { parameters } = load({ hpCount: 1e9, frontHeight: 0, upperRound: 99, lowerChamfer: 99 });
    const { blankPanelHp, ...rest } = parameters;
    expect(() => caseParams(rest)).not.toThrow();
    expect(blankPanelHp).toBeGreaterThan(0);
  });
});
