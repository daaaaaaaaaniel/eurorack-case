/**
 * The modelling worker. OpenCascade runs here so the page stays responsive
 * while a rebuild takes a second or two.
 *
 * Messages in:  { id, kind: "build", params, panelHp }
 *               { id, kind: "export", part, format: "stl" | "step" }
 * Messages out: { id, kind: "built", parts, stats, ms }
 *               { id, kind: "file", name, buffer }
 *               { id, kind: "error", message }
 */
import wasmUrl from "replicad-opencascadejs/wasm?url";
import { measureVolume, type Shape3D } from "replicad";

import { initOC } from "./oc";
import { caseParams, HP, type CaseParams, type CaseParamsInput } from "./model/params";
import { blankPanel, caseShell, endCap, Floor, wallHoleZs } from "./model/parts";

export type PartName = "case" | "capL" | "capR" | "panel";

export interface MeshPayload {
  positions: Float32Array;
  normals: Float32Array;
  indices: Uint32Array;
  lines: Float32Array;
  volume: number;
}

export interface Stats {
  width: number;
  outerDepth: number;
  height: number;
  tiltDeg: number;
  railSpacing: number;
  frontScrews: number;
  rearScrews: number;
}

export type BuildRequest = { id: number; kind: "build"; params: CaseParamsInput; panelHp: number };
export type ExportRequest = { id: number; kind: "export"; part: PartName; format: "stl" | "step" };
export type Request = BuildRequest | ExportRequest;

export type BuiltMessage = { id: number; kind: "built"; parts: Partial<Record<PartName, MeshPayload>>; stats: Stats; ms: number };
export type FileMessage = { id: number; kind: "file"; name: string; buffer: ArrayBuffer };
export type ErrorMessage = { id: number; kind: "error"; message: string };
export type Response = BuiltMessage | FileMessage | ErrorMessage;

const shapes: Partial<Record<PartName, Shape3D>> = {};
let lastParams: CaseParams | null = null;

// the DOM lib types postMessage for Window; this is a dedicated worker
const post = (self as unknown as { postMessage: (message: Response, transfer?: Transferable[]) => void }).postMessage.bind(self);
const buf = (a: ArrayBufferView): ArrayBuffer => a.buffer as ArrayBuffer;

const MESH = { tolerance: 0.05, angularTolerance: 0.2 };

function payload(shape: Shape3D): [MeshPayload, ArrayBuffer[]] {
  const m = shape.mesh(MESH);
  const e = shape.meshEdges(MESH);
  const out: MeshPayload = {
    positions: new Float32Array(m.vertices),
    normals: new Float32Array(m.normals),
    indices: new Uint32Array(m.triangles),
    lines: new Float32Array(e.lines),
    volume: measureVolume(shape),
  };
  return [out, [buf(out.positions), buf(out.normals), buf(out.indices), buf(out.lines)]];
}

function stats(p: CaseParams): Stats {
  const fl = new Floor(p);
  const yLeg = p.innerHalf - p.tabClearance - p.endCapTabThickness;
  return {
    width: p.width,
    outerDepth: p.outerDepth,
    height: Math.max(p.frontHeight, p.rearHeight),
    tiltDeg: Math.atan2(p.frontHeight - p.rearHeight, p.outerDepth) * 180 / Math.PI,
    railSpacing: p.panelHeight - 2 * p.railInset,
    frontScrews: wallHoleZs(p, fl, p.frontHeight, -yLeg).length,
    rearScrews: wallHoleZs(p, fl, p.rearHeight, yLeg).length,
  };
}

async function build(req: BuildRequest): Promise<void> {
  const t0 = performance.now();
  const p = caseParams(req.params);
  lastParams = p;
  for (const k of Object.keys(shapes) as PartName[]) delete shapes[k];
  shapes.case = caseShell(p);
  if (!p.closedEnds.includes("left")) shapes.capL = endCap(p, "left");
  shapes.capR = endCap(p, "right");
  shapes.panel = blankPanel(p, Math.min(req.panelHp, p.hpCount));

  const parts: Partial<Record<PartName, MeshPayload>> = {};
  const transfer: ArrayBuffer[] = [];
  for (const [name, shape] of Object.entries(shapes) as [PartName, Shape3D][]) {
    const [pl, buffers] = payload(shape);
    parts[name] = pl;
    transfer.push(...buffers);
  }
  const msg: BuiltMessage = { id: req.id, kind: "built", parts, stats: stats(p), ms: performance.now() - t0 };
  post(msg, transfer);
}

async function exportPart(req: ExportRequest): Promise<void> {
  const shape = shapes[req.part];
  if (!shape || !lastParams) throw new Error("nothing built yet");
  const p = lastParams;
  const label = { case: "case", capL: "end-cap-left", capR: "end-cap-right", panel: "blank-panel" }[req.part];
  const cfg = `${p.hpCount}hp-${p.frontHeight}-${p.rearHeight}${p.leftWall ? "-asym" : ""}`;
  const blob = req.format === "stl" ? shape.blobSTL({ ...MESH, binary: true }) : shape.blobSTEP();
  const buffer = await blob.arrayBuffer();
  const msg: FileMessage = { id: req.id, kind: "file", name: `${label}-${cfg}.${req.format}`, buffer };
  post(msg, [buffer]);
}

const ready = initOC(() => wasmUrl);

onmessage = async (ev: MessageEvent<Request>) => {
  const req = ev.data;
  try {
    await ready;
    if (req.kind === "build") await build(req);
    else await exportPart(req);
  } catch (err) {
    const msg: ErrorMessage = { id: req.id, kind: "error", message: err instanceof Error ? err.message : String(err) };
    post(msg);
  }
};

export { HP };
