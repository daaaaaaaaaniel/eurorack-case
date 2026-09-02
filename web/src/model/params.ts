/**
 * Parameters for the Eurorack case — a port of eurorack_case/params.py.
 *
 * Names follow the Onshape variable table (docs/variables.md). The first block
 * is the Onshape configuration; the rest are the design constants that were
 * `#variables` in the Part Studio. Millimetres throughout.
 */

export const HP = 5.08;

export type LipStyle = "round" | "sharp" | "chamfer";
export const LIP_STYLES: readonly LipStyle[] = ["round", "sharp", "chamfer"];

export interface CaseParamsInput {
  // --- configuration inputs ---------------------------------------------
  hpCount?: number;
  frontHeight?: number;        // Front_Height: outer height of the front wall
  rearHeight?: number;         // RearHeight:   outer height of the rear wall
  topLips?: LipStyle;
  upperRound?: number;
  upperChamfer?: number;
  bottomLips?: LipStyle;
  lowerRound?: number;
  lowerChamfer?: number;       // Lower_Lip_Bevel
  leftWall?: boolean;          // true = "asym" Part Studio: X = 0 closed by an integral wall

  // --- shell --------------------------------------------------------------
  panelHeight?: number;        // PanelHeight: clear width between the inner walls
  panelThickness?: number;     // PanelThickness: depth of the panel recess
  wallThickness?: number;      // CaseFrontBackThickness
  bottomThickness?: number;    // CaseBottomThickness

  // --- rails ----------------------------------------------------------------
  railDepth?: number;          // drawn 7.798 in the sketch; RailBlockDepth (8) is never referenced
  railHeight?: number;         // solved height of the rail block
  railInset?: number;          // RailBlockPanelInset: bolt axis from the inner wall
  railBoltWidth?: number;      // RailBlockBoltWidth
  railBoltDepth?: number;      // RailBlockBoltDepth
  railNutWidth?: number;       // RailBlockNutWidth: sizes the nut traps in the tab
  railNutSlotWidth?: number;   // the rail's sliding-nut slot: undimensioned, solved to 5.597
  railNutThickness?: number;   // RailBlockNutThickness
  railNutDepth?: number;       // RailBlockNutDepth
  nutClearance?: number;       // traps are cut RailBlockNutWidth - .1mm

  // --- end caps ---------------------------------------------------------------
  endCapThickness?: number;    // EndCapThickness (= wall thickness in the source)
  endCapTabThickness?: number; // EndCapTabThickness
  endCapFaceChamfer?: number;  // edge break around the cap's outer face
  tabClearance?: number;       // shrink the tab for a printable fit (0 in the source)

  // --- end cap screws (M3, through the shell into the tab) -------------------
  boltThroughDiam?: number;    // BoltThrougDiam
  boltCounterboreDiam?: number;  // BoltCounterboreDiam
  boltCounterboreDepth?: number; // BoltCounterboreThick
  bottomHoleInset?: number;    // BottomHoleInset: screw axis from the case end
  bottomHoleSpacing?: number;  // BottomHoleSpacing
  wallHoleSpacing?: number;    // RearHoleSpacing

  // --- blank test panel -------------------------------------------------------
  panelHoleDiam?: number;
  panelHoleEdgeInset?: number; // PanelHoleVerticalInset
  panelHoleSideInset?: number;
}

export type CaseParams = Required<CaseParamsInput> & {
  readonly width: number;
  readonly innerHalf: number;
  readonly outerHalf: number;
  readonly outerDepth: number;      // Onshape's measured `BaseCase`, 137.5
  readonly railTop: number;
  readonly railBottom: number;
  readonly nutPocketWidth: number;
  readonly endCapTabDepth: number;  // #BottomHoleInset + .7 * #BoltCounterboreDiam
  readonly closedEnds: readonly ("left" | "right")[];
};

export const DEFAULTS: Required<CaseParamsInput> = {
  hpCount: 26,
  frontHeight: 30,
  rearHeight: 30,
  topLips: "round",
  upperRound: 1,
  upperChamfer: 1,
  bottomLips: "round",
  lowerRound: 1,
  lowerChamfer: 1,
  leftWall: false,

  panelHeight: 129.5,
  panelThickness: 2,
  wallThickness: 4,
  bottomThickness: 4,

  railDepth: 7.798472,
  railHeight: 10,
  railInset: 3,
  railBoltWidth: 3.2,
  railBoltDepth: 8,
  railNutWidth: 5.8,
  railNutSlotWidth: 5.596945,
  railNutThickness: 2.5,
  railNutDepth: 2,
  nutClearance: 0.1,

  endCapThickness: 4,
  endCapTabThickness: 5,
  endCapFaceChamfer: 1.5,
  tabClearance: 0,

  boltThroughDiam: 3.3,
  boltCounterboreDiam: 6,
  boltCounterboreDepth: 1.75,
  bottomHoleInset: 4,
  bottomHoleSpacing: 55,
  wallHoleSpacing: 23,

  panelHoleDiam: 3.2,
  panelHoleEdgeInset: 3,
  panelHoleSideInset: 7.5,
};

export function caseParams(input: CaseParamsInput = {}): CaseParams {
  const p = { ...DEFAULTS, ...input };
  if (!LIP_STYLES.includes(p.topLips) || !LIP_STYLES.includes(p.bottomLips)) {
    throw new Error(`lip style must be one of ${LIP_STYLES.join(", ")}`);
  }
  if (!Number.isInteger(p.hpCount) || p.hpCount < 2) throw new Error("hpCount must be an integer of at least 2");
  const minimum = p.panelThickness + p.railHeight + p.bottomThickness + p.endCapTabThickness;
  for (const name of ["frontHeight", "rearHeight"] as const) {
    if (p[name] < minimum) {
      throw new Error(`${name} must be at least ${minimum} mm to fit the end cap tab between the rail and the floor`);
    }
  }
  // the wall top is only wallThickness wide before it drops into the panel recess,
  // so an upper lip has to be smaller than that to have a face to land on
  const upper = p.topLips === "round" ? p.upperRound : p.topLips === "chamfer" ? p.upperChamfer : 0;
  if (upper >= p.wallThickness) {
    throw new Error(`the top lip (${upper} mm) must be smaller than the wall thickness (${p.wallThickness} mm)`);
  }
  const innerHalf = p.panelHeight / 2;
  const outerHalf = innerHalf + p.wallThickness;
  return {
    ...p,
    width: p.hpCount * HP,
    innerHalf,
    outerHalf,
    outerDepth: 2 * outerHalf,
    railTop: -p.panelThickness,
    railBottom: -p.panelThickness - p.railHeight,
    nutPocketWidth: p.railNutWidth - p.nutClearance,
    endCapTabDepth: p.bottomHoleInset + 0.7 * p.boltCounterboreDiam,
    closedEnds: p.leftWall ? ["left"] : [],
  };
}
