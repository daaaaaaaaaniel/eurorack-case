/**
 * The saved configuration: the parameters the page exposes, as JSON.
 *
 * JSON rather than CSV or XML because this is one typed record — numbers, two
 * enums and a flag — not a table. It maps onto the model's own parameter names
 * with no translation, parses natively, and stays readable and hand-editable.
 *
 * Only the controls on the page are saved. Everything else (wall thickness,
 * rail geometry, screw sizes) comes from this app's defaults when the file is
 * loaded, so a configuration follows the current model rather than pinning the
 * values it was written with.
 *
 * A configuration coming back in is untrusted: it may be hand-edited, from a
 * later version, or not one of ours at all. Nothing is spread into the model —
 * every field is read by name and checked, and unknown keys are ignored.
 */
import { DEFAULTS, LIP_STYLES, type CaseParamsInput, type LipStyle } from "./model/params";

export const CONFIG_FORMAT = "eurorack-case";
export const CONFIG_VERSION = 1;

/** Exactly what the page can set, and what a load restores. */
export interface SavedParameters {
  hpCount: number;
  frontHeight: number;
  rearHeight: number;
  topLips: LipStyle;
  upperRound: number;
  upperChamfer: number;
  bottomLips: LipStyle;
  lowerRound: number;
  lowerChamfer: number;
  leftWall: boolean;
  tabClearance: number;
  blankPanelHp: number;
}

export interface SavedConfig {
  format: typeof CONFIG_FORMAT;
  version: number;
  generated: string;
  source: string;
  parameters: SavedParameters;
}

/**
 * The range each number is accepted in — the range of the control that sets it,
 * so a loaded value is always one the page can show.
 */
const RANGES: Record<string, [number, number]> = {
  hpCount: [2, 168],
  frontHeight: [21, 200],
  rearHeight: [21, 200],
  upperRound: [0.5, 3.5],
  upperChamfer: [0.5, 3.5],
  lowerRound: [0.5, 10],
  lowerChamfer: [0.5, 10],
  tabClearance: [0, 0.6],
  blankPanelHp: [2, 168],
};

const WHOLE = new Set(["hpCount", "blankPanelHp"]);

export function buildConfig(params: Required<CaseParamsInput>, blankPanelHp: number): SavedConfig {
  return {
    format: CONFIG_FORMAT,
    version: CONFIG_VERSION,
    generated: new Date().toISOString(),
    source: "https://github.com/daaaaaaaaaniel/eurorack-case",
    parameters: {
      hpCount: params.hpCount,
      frontHeight: params.frontHeight,
      rearHeight: params.rearHeight,
      topLips: params.topLips,
      // both lip sizes travel, so changing style after a load recovers the size
      // that was set for it rather than dropping back to the default
      upperRound: params.upperRound,
      upperChamfer: params.upperChamfer,
      bottomLips: params.bottomLips,
      lowerRound: params.lowerRound,
      lowerChamfer: params.lowerChamfer,
      leftWall: params.leftWall,
      tabClearance: params.tabClearance,
      blankPanelHp,
    },
  };
}

export function configText(config: SavedConfig): string {
  return `${JSON.stringify(config, null, 2)}\n`;
}

export interface LoadedConfig {
  parameters: SavedParameters;
  /** Everything that had to be corrected, in words fit for the status line. */
  warnings: string[];
}

function readNumber(raw: unknown, key: string, fallback: number, warnings: string[]): number {
  if (raw === undefined) return fallback;
  if (typeof raw !== "number" || !Number.isFinite(raw)) {
    warnings.push(`${key} is not a number, kept ${fallback}`);
    return fallback;
  }
  let v = WHOLE.has(key) ? Math.round(raw) : raw;
  const [lo, hi] = RANGES[key];
  if (v < lo || v > hi) {
    const held = Math.min(hi, Math.max(lo, v));
    warnings.push(`${key} ${v} is outside ${lo}–${hi}, used ${held}`);
    v = held;
  }
  return v;
}

function readLipStyle(raw: unknown, key: string, fallback: LipStyle, warnings: string[]): LipStyle {
  if (raw === undefined) return fallback;
  if (typeof raw === "string" && (LIP_STYLES as readonly string[]).includes(raw)) return raw as LipStyle;
  warnings.push(`${key} "${String(raw)}" is not a lip style, kept ${fallback}`);
  return fallback;
}

function readBoolean(raw: unknown, key: string, fallback: boolean, warnings: string[]): boolean {
  if (raw === undefined) return fallback;
  if (typeof raw === "boolean") return raw;
  warnings.push(`${key} is not true or false, kept ${fallback}`);
  return fallback;
}

/**
 * Read a configuration file. Throws with a readable reason when the text is not
 * a configuration at all; anything merely wrong inside one is corrected and
 * reported through `warnings`.
 */
export function parseConfig(text: string): LoadedConfig {
  let doc: unknown;
  try {
    doc = JSON.parse(text);
  } catch {
    throw new Error("that file is not JSON");
  }
  if (typeof doc !== "object" || doc === null || Array.isArray(doc)) {
    throw new Error("a configuration file holds a single JSON object");
  }
  const root = doc as Record<string, unknown>;
  if (root.format !== CONFIG_FORMAT) {
    throw new Error(`that file is not a ${CONFIG_FORMAT} configuration`);
  }

  const warnings: string[] = [];
  if (typeof root.version === "number" && root.version > CONFIG_VERSION) {
    warnings.push(`the file is version ${root.version} and this page reads ${CONFIG_VERSION}`);
  }
  const p = (typeof root.parameters === "object" && root.parameters !== null && !Array.isArray(root.parameters))
    ? root.parameters as Record<string, unknown>
    : {};

  const parameters: SavedParameters = {
    hpCount: readNumber(p.hpCount, "hpCount", DEFAULTS.hpCount, warnings),
    frontHeight: readNumber(p.frontHeight, "frontHeight", DEFAULTS.frontHeight, warnings),
    rearHeight: readNumber(p.rearHeight, "rearHeight", DEFAULTS.rearHeight, warnings),
    topLips: readLipStyle(p.topLips, "topLips", DEFAULTS.topLips, warnings),
    upperRound: readNumber(p.upperRound, "upperRound", DEFAULTS.upperRound, warnings),
    upperChamfer: readNumber(p.upperChamfer, "upperChamfer", DEFAULTS.upperChamfer, warnings),
    bottomLips: readLipStyle(p.bottomLips, "bottomLips", DEFAULTS.bottomLips, warnings),
    lowerRound: readNumber(p.lowerRound, "lowerRound", DEFAULTS.lowerRound, warnings),
    lowerChamfer: readNumber(p.lowerChamfer, "lowerChamfer", DEFAULTS.lowerChamfer, warnings),
    leftWall: readBoolean(p.leftWall, "leftWall", DEFAULTS.leftWall, warnings),
    tabClearance: readNumber(p.tabClearance, "tabClearance", DEFAULTS.tabClearance, warnings),
    blankPanelHp: readNumber(p.blankPanelHp, "blankPanelHp", 6, warnings),
  };
  // the blank panel cannot be wider than the case
  if (parameters.blankPanelHp > parameters.hpCount) parameters.blankPanelHp = parameters.hpCount;

  return { parameters, warnings };
}
