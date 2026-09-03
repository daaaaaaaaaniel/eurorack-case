/**
 * Download names.
 *
 * A part is named for its own name in the code and the parameters that
 * actually shape it, so two files with the same name hold the same geometry.
 * The end caps are a cross-section: they do not change with the case's width,
 * so they carry no HP. The blank panel depends only on its own width.
 *
 *   case_26hp_30mm-front_45mm-rear.stl
 *   capL_30mm-front_45mm-rear.stl
 *   capR_30mm-front_45mm-rear.stl
 *   panel_6hp.stl
 *
 * The lips, the tab clearance and the rest are recorded in the configuration
 * file rather than the name — the name stays readable, config.json is the
 * complete record.
 */
import type { CaseParams } from "./model/params";
import type { PartName } from "./worker";

/** 30 → "30", 30.5 → "30.5": no trailing zeros in a file name. */
const num = (v: number): string => String(Number(v.toFixed(2)));

const heights = (p: CaseParams): string =>
  `${num(p.frontHeight)}mm-front_${num(p.rearHeight)}mm-rear`;

/** The name of one part, without an extension. */
export function partStem(p: CaseParams, part: PartName, panelHp: number): string {
  switch (part) {
    case "case": return `case_${num(p.hpCount)}hp_${heights(p)}`;
    case "capL": return `capL_${heights(p)}`;
    case "capR": return `capR_${heights(p)}`;
    case "panel": return `panel_${num(panelHp)}hp`;
  }
}

export function partFileName(p: CaseParams, part: PartName, panelHp: number, format: "stl" | "step"): string {
  return `${partStem(p, part, panelHp)}.${format}`;
}

/** Anything that is not a single bare file comes down under one fixed name. */
export const BUNDLE_NAME = "case.zip";
export const CONFIG_MEMBER = "config.json";
