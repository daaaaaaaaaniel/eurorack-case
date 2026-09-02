/**
 * Parts of the Eurorack case in replicad — a port of eurorack_case/parts.py.
 *
 * Frame: X runs along the rails (0 .. width), Y runs front (-) to rear (+) and
 * is centred on the panel, Z is up with the top of the walls at Z = 0.
 *
 *   caseShell()   the shell: sloped floor, front/rear walls, T-slot rails,
 *                 screw holes for the end caps; open at both ends, or closed
 *                 at X = 0 by an integral wall (leftWall)
 *   endCap()      4 mm plate closing one end, with a 5 mm tab that plugs into
 *                 the shell and carries M3 nut traps
 *   blankPanel()  a blank module panel, to check the rail spacing
 */
import {
  draw,
  drawCircle,
  drawRectangle,
  makeCylinder,
  Plane,
  type AnyShape,
  type Drawing,
  type EdgeFinder,
  type Shape3D,
} from "replicad";

import { HP, caseParams, type CaseParams, type CaseParamsInput } from "./params";

type Pt = [number, number];
type Vec3 = [number, number, number];

const EPS = 1e-3;

/** replicad types a sketch extrusion as any shape; ours are always solids. */
const solid = (s: AnyShape): Shape3D => s as Shape3D;

const add = (a: Vec3, b: Vec3, k = 1): Vec3 => [a[0] + b[0] * k, a[1] + b[1] * k, a[2] + b[2] * k];
const neg = (a: Vec3): Vec3 => [-a[0], -a[1], -a[2]];

/** The sloped bottom plate, as the line joining the two wall feet. */
export class Floor {
  readonly y0: number; readonly z0: number; readonly y1: number; readonly z1: number;
  readonly slope: number;
  readonly sec: number;           // 1 / cos(tilt)
  readonly inward: Vec3;          // unit normal pointing into the case

  constructor(p: CaseParams) {
    this.y0 = -p.outerHalf; this.z0 = -p.frontHeight;
    this.y1 = p.outerHalf; this.z1 = -p.rearHeight;
    const dy = this.y1 - this.y0, dz = this.z1 - this.z0;
    const length = Math.hypot(dy, dz);
    this.slope = dz / dy;
    this.sec = length / dy;
    this.inward = [0, -dz / length, dy / length];
  }

  zOuter(y: number): number { return this.z0 + (y - this.y0) * this.slope; }

  /** Z of the line `offset` mm inside the outer floor surface, at Y = y. */
  zAt(y: number, offset: number): number { return this.zOuter(y) + offset * this.sec; }

  /** Workplane on the outside of the floor. Local x = X, normal points out. */
  outerPlane(): Plane { return new Plane([0, 0, this.zOuter(0)], [1, 0, 0], neg(this.inward)); }
}

export const frontPlane = (p: CaseParams): Plane => new Plane([0, -p.outerHalf, 0], [1, 0, 0], [0, -1, 0]);
export const rearPlane = (p: CaseParams): Plane => new Plane([0, p.outerHalf, 0], [1, 0, 0], [0, 1, 0]);

/** A closed (Y, Z) polygon, extruded from X = x0 by `length` along +X. */
function profile(points: Pt[], length: number, x0 = 0): Shape3D {
  const pen = draw(points[0]);
  for (const pt of points.slice(1)) pen.lineTo(pt);
  return solid(pen.close().sketchOnPlane("YZ", x0).extrude(length));
}

/** A (Y, Z) rectangle centred at (cy, cz), extruded along X. */
function bar(cy: number, cz: number, w: number, h: number, length: number): Shape3D {
  return solid(drawRectangle(w, h).translate(cy, cz).sketchOnPlane("YZ").extrude(length));
}

/**
 * Edges parallel to X lying on the line through (Y, Z) = (y, z).
 *
 * Selecting by position replaces Onshape's history-based references. A thin
 * box along the whole line also catches collinear pieces, which is what the
 * integral wall's join leaves behind.
 */
function longEdges(f: EdgeFinder, yz: Pt[], xMin: number, xMax: number): EdgeFinder {
  return f.inDirection("X").either(
    yz.map(([y, z]) => (g: EdgeFinder) => g.inBox([xMin - 1, y - 0.05, z - 0.05], [xMax + 1, y + 0.05, z + 0.05])),
  );
}

/** Round / chamfer / leave the four long outer edges, per the configuration. */
function applyLips(body: Shape3D, p: CaseParams, xMin: number, xMax: number): Shape3D {
  const yo = p.outerHalf;
  const top: Pt[] = [[-yo, 0], [yo, 0]];
  const bottom: Pt[] = [[-yo, -p.frontHeight], [yo, -p.rearHeight]];
  const passes: [string, number, number, Pt[]][] = [
    [p.topLips, p.upperRound, p.upperChamfer, top],
    [p.bottomLips, p.lowerRound, p.lowerChamfer, bottom],
  ];
  for (const [style, round, chamfer, edges] of passes) {
    if (style === "round") body = body.fillet(round, (e) => longEdges(e, edges, xMin, xMax));
    else if (style === "chamfer") body = body.chamfer(chamfer, (e) => longEdges(e, edges, xMin, xMax));
  }
  return body;
}

// --------------------------------------------------------------------------
// screws that hold the end caps on
// --------------------------------------------------------------------------

/**
 * Z of the screws through a wall of the given outer height.
 *
 * The source puts the first screw at mid-height and patterns the rest at
 * `wallHoleSpacing`. Keep every position whose nut trap fits in the tab's leg
 * — between the underside of the rail and the tab's floor — and whose
 * counterbore stays on the wall.
 */
export function wallHoleZs(p: CaseParams, fl: Floor, height: number, yLegInner: number): number[] {
  const halfPocket = p.nutPocketWidth / 2, halfCb = p.boltCounterboreDiam / 2;
  const legTop = p.railBottom;
  const legFloor = fl.zAt(yLegInner, p.bottomThickness + p.tabClearance + p.endCapTabThickness);
  const zs: number[] = [];
  for (let k = -8; k <= 8; k++) {
    const z = -height / 2 + k * p.wallHoleSpacing;
    if (z + halfPocket > legTop + EPS || z - halfPocket < legFloor - EPS) continue;
    if (z + halfCb > 0 || z - halfCb < -height) continue;
    zs.push(z);
  }
  return zs.sort((a, b) => a - b);
}

interface ScrewSite { point: Vec3; normal: Vec3 }

/** Where each screw enters the shell at one end (axis at X = x), with the outward normal. */
function screwSites(p: CaseParams, fl: Floor, x: number): ScrewSite[] {
  const yi = p.innerHalf, yo = p.outerHalf, tt = p.endCapTabThickness, c = p.tabClearance;
  const sites: ScrewSite[] = [];
  const floor = fl.outerPlane();
  for (const s of [-p.bottomHoleSpacing, 0, p.bottomHoleSpacing]) {
    const w = floor.toWorldCoords([x, s, 0]);
    sites.push({ point: [w.x, w.y, w.z], normal: neg(fl.inward) });
  }
  for (const z of wallHoleZs(p, fl, p.frontHeight, -(yi - c - tt))) sites.push({ point: [x, -yo, z], normal: [0, -1, 0] });
  for (const z of wallHoleZs(p, fl, p.rearHeight, yi - c - tt)) sites.push({ point: [x, yo, z], normal: [0, 1, 0] });
  return sites;
}

/**
 * Counterbore + through hole + nut trap for one screw. `into` is the distance
 * from the outer surface to the tab's inner face, where the trap opens.
 */
function screwCutters(site: ScrewSite, p: CaseParams, into: number): Shape3D[] {
  const { point, normal } = site;
  const counterbore = makeCylinder(p.boltCounterboreDiam / 2, p.boltCounterboreDepth, point, neg(normal));
  const through = makeCylinder(p.boltThroughDiam / 2, into + 1, point, neg(normal));
  const pocketPlane = new Plane(add(point, normal, -into), [1, 0, 0], normal);
  const pocket = solid(drawRectangle(p.nutPocketWidth, p.nutPocketWidth).sketchOnPlane(pocketPlane).extrude(p.railNutDepth));
  return [counterbore, through, pocket];
}

function cutAll(body: Shape3D, tools: Shape3D[]): Shape3D {
  for (const t of tools) body = body.cut(t);
  return body;
}

function endScrewCutters(p: CaseParams, fl: Floor, x: number): Shape3D[] {
  const into = p.wallThickness + p.tabClearance + p.endCapTabThickness;
  return screwSites(p, fl, x).flatMap((s) => screwCutters(s, p, into));
}

/** Screw sets for every end that takes a removable cap. */
function allScrewCutters(p: CaseParams, fl: Floor): Shape3D[] {
  const right = endScrewCutters(p, fl, p.width - p.bottomHoleInset);
  if (p.closedEnds.includes("left")) return right;
  return [...endScrewCutters(p, fl, p.bottomHoleInset), ...right];
}

// --------------------------------------------------------------------------
// parts
// --------------------------------------------------------------------------

function shellProfile(p: CaseParams, fl: Floor): Pt[] {
  const yi = p.innerHalf, yo = p.outerHalf, t = p.bottomThickness;
  return [
    [-yo, 0], [-yo, -p.frontHeight], [yo, -p.rearHeight], [yo, 0],
    [yi, 0], [yi, fl.zAt(yi, t)], [-yi, fl.zAt(-yi, t)], [-yi, 0],
  ];
}

function endPlateProfile(p: CaseParams): Pt[] {
  const yo = p.outerHalf;
  return [[-yo, 0], [-yo, -p.frontHeight], [yo, -p.rearHeight], [yo, 0]];
}

/** U-shaped band lining the cavity below the rails. */
function tabProfile(p: CaseParams, fl: Floor): Pt[] {
  const c = p.tabClearance, tt = p.endCapTabThickness, bt = p.bottomThickness;
  const yo = p.innerHalf - c;      // outside of the tab
  const yi = yo - tt;              // inside of the tab
  const top = p.railBottom - c;
  return [
    [-yo, top], [-yo, fl.zAt(-yo, bt + c)], [yo, fl.zAt(yo, bt + c)], [yo, top],
    [yi, top], [yi, fl.zAt(yi, bt + c + tt)], [-yi, fl.zAt(-yi, bt + c + tt)], [-yi, top],
  ];
}

export function caseShell(input: CaseParamsInput | CaseParams = {}): Shape3D {
  const p = "width" in input ? input : caseParams(input);
  const fl = new Floor(p);
  const w = p.width;
  let body = profile(shellProfile(p, fl), w);

  // T-slot rails along both inner walls, under the panel recess
  const yi = p.innerHalf;
  const railCz = (p.railTop + p.railBottom) / 2;
  const slotTop = p.railTop + 1;                 // break cleanly into the recess
  const slotBottom = p.railTop - p.railBoltDepth;
  const nutTop = p.railTop - p.railNutDepth;
  const nutBottom = nutTop - p.railNutThickness;
  for (const s of [1, -1]) {
    body = body.fuse(bar(s * (yi - p.railDepth / 2), railCz, p.railDepth, p.railHeight, w));
    const axis = s * (yi - p.railInset);
    body = body.cut(bar(axis, (slotTop + slotBottom) / 2, p.railBoltWidth, slotTop - slotBottom, w));
    body = body.cut(bar(axis, (nutTop + nutBottom) / 2, p.railNutSlotWidth, nutTop - nutBottom, w));
  }

  let xMin = 0;
  if (p.leftWall) {
    // the "asym" variant: a plate with the outer profile closes X = 0 and the lips
    // run along it uninterrupted. Unlike a cap, its outside face is not edge-broken.
    body = body.fuse(profile(endPlateProfile(p), p.endCapThickness, -p.endCapThickness));
    xMin = -p.endCapThickness;
  }

  body = applyLips(body, p, xMin, w);
  return cutAll(body, allScrewCutters(p, fl));
}

/** End cap in its assembled position. `left` closes X = 0, `right` closes X = width. */
export function endCap(input: CaseParamsInput | CaseParams = {}, end: "left" | "right" = "left"): Shape3D {
  const p = "width" in input ? input : caseParams(input);
  if (p.closedEnds.includes(end)) throw new Error(`the ${end} end is an integral wall in this configuration`);
  const fl = new Floor(p);
  const x0 = -p.endCapThickness;
  let plate = profile(endPlateProfile(p), p.endCapThickness, x0);
  plate = plate.chamfer(p.endCapFaceChamfer, (e) => e.inPlane("YZ", x0));
  plate = applyLips(plate, p, x0, 0);
  const tab = profile(tabProfile(p, fl), p.endCapTabDepth);
  let cap = cutAll(plate.fuse(tab), endScrewCutters(p, fl, p.bottomHoleInset));
  if (end === "right") cap = cap.mirror("YZ", [p.width / 2, 0, 0]);
  return cap;
}

/** A blank module panel `hp` wide, sitting in the recess from X = x0. */
export function blankPanel(input: CaseParamsInput | CaseParams = {}, hp = 6, x0 = 0): Shape3D {
  const p = "width" in input ? input : caseParams(input);
  const w = hp * HP, yi = p.innerHalf;
  let panel: Drawing = drawRectangle(w, p.panelHeight).translate(x0 + w / 2, 0);
  for (const x of [x0 + p.panelHoleSideInset, x0 + w - p.panelHoleSideInset]) {
    for (const y of [-(yi - p.panelHoleEdgeInset), yi - p.panelHoleEdgeInset]) {
      panel = panel.cut(drawCircle(p.panelHoleDiam / 2).translate(x, y));
    }
  }
  return solid(panel.sketchOnPlane("XY", -p.panelThickness).extrude(p.panelThickness));
}
