/** Page wiring: controls → worker → scene, and file downloads. */
import { Scene } from "./scene";
import type { BuiltMessage, PartName, Request, Response, Stats } from "./worker";
import { DEFAULTS, type CaseParamsInput, type LipStyle } from "./model/params";

const $ = <T extends HTMLElement = HTMLElement>(id: string) => document.getElementById(id) as T;
const HP = 5.08;

// ---- worker client -----------------------------------------------------------
const worker = new Worker(new URL("./worker.ts", import.meta.url), { type: "module" });
let seq = 0;
const pending = new Map<number, { resolve: (r: Response) => void; reject: (e: Error) => void }>();
worker.onmessage = (ev: MessageEvent<Response>) => {
  const p = pending.get(ev.data.id);
  if (!p) return;
  pending.delete(ev.data.id);
  if (ev.data.kind === "error") p.reject(new Error(ev.data.message)); else p.resolve(ev.data);
};
type Ask = Request extends infer R ? (R extends Request ? Omit<R, "id"> : never) : never;
worker.onerror = (ev: ErrorEvent) => {
  const msg = `The modelling worker failed: ${ev.message || "unknown error"}`;
  for (const p of pending.values()) p.reject(new Error(msg));
  pending.clear();
  const b = document.getElementById("banner")!;
  b.querySelector("p")!.textContent = msg;
  b.classList.add("show");
};
function ask(req: Ask): Promise<Response> {
  const id = ++seq;
  return new Promise((resolve, reject) => {
    pending.set(id, { resolve, reject });
    worker.postMessage({ ...req, id });
  });
}

// ---- state -------------------------------------------------------------------
const state = {
  params: { ...DEFAULTS } as Required<CaseParamsInput>,
  panelHp: 6,
  explode: 0,
  show: { case: true, caps: true, panel: true },
  stats: null as Stats | null,
  building: false,
  dirty: false,
};

const scene = new Scene($<HTMLCanvasElement>("c"));
const status = $("status");
const banner = $("banner");

function lipSize(which: "top" | "bottom"): number {
  const p = state.params;
  if (which === "top") return p.topLips === "chamfer" ? p.upperChamfer : p.upperRound;
  return p.bottomLips === "chamfer" ? p.lowerChamfer : p.lowerRound;
}

function showValues(): void {
  const p = state.params;
  $("hp-v").textContent = String(p.hpCount);
  $("front-v").textContent = String(p.frontHeight);
  $("rear-v").textContent = String(p.rearHeight);
  $("top-size-v").textContent = lipSize("top").toFixed(1);
  $("bottom-size-v").textContent = lipSize("bottom").toFixed(1);
  $("php-v").textContent = String(state.panelHp);
  $("clr-v").textContent = p.tabClearance.toFixed(2);
  $("explode-v").textContent = state.explode.toFixed(2);
  $<HTMLInputElement>("top-size").disabled = p.topLips === "sharp";
  $<HTMLInputElement>("bottom-size").disabled = p.bottomLips === "sharp";
  $<HTMLInputElement>("php").max = String(p.hpCount);
  const capL = $<HTMLOptionElement>("opt-capL");
  capL.disabled = p.leftWall;
  if (p.leftWall && $<HTMLSelectElement>("export-part").value === "capL") $<HTMLSelectElement>("export-part").value = "case";
}

function readout(): void {
  const s = state.stats;
  if (!s) return;
  const mm = (v: number, d = 1) => `${v.toFixed(d)} <small>mm</small>`;
  $("r-len").innerHTML = mm(s.width, 2);
  $("r-lencaps").innerHTML = mm(s.width + 2 * state.params.endCapThickness, 2);
  $("r-depth").innerHTML = mm(s.outerDepth);
  $("r-height").innerHTML = mm(s.height, 0);
  $("r-tilt").innerHTML = s.tiltDeg === 0 ? "level" : `${Math.abs(s.tiltDeg).toFixed(1)}° ${s.tiltDeg > 0 ? "toward rear" : "toward front"}`;
  $("r-rails").innerHTML = mm(s.railSpacing);
  $("r-screws").innerHTML = `3 floor · ${s.frontScrews} front · ${s.rearScrews} rear`;
}

function layout(): void {
  scene.groups.case.visible = state.show.case;
  scene.groups.capL.visible = state.show.caps && !state.params.leftWall;
  scene.groups.capR.visible = state.show.caps;
  scene.groups.panel.visible = state.show.panel;
  scene.explode(state.explode);
}

let firstBuild = true;
async function rebuild(): Promise<void> {
  if (state.building) { state.dirty = true; return; }
  state.building = true;
  status.textContent = firstBuild ? "Starting OpenCascade…" : "Building…";
  status.className = "src busy";
  try {
    const r = (await ask({ kind: "build", params: state.params, panelHp: state.panelHp })) as BuiltMessage;
    for (const name of ["case", "capL", "capR", "panel"] as PartName[]) scene.setPart(name, r.parts[name]);
    state.stats = r.stats;
    const vol = (v?: number) => (v === undefined ? "" : `${(v / 1000).toFixed(1)} cm³`);
    $("vol-case").textContent = vol(r.parts.case?.volume);
    $("vol-caps").textContent = vol((r.parts.capL?.volume ?? 0) + (r.parts.capR?.volume ?? 0));
    $("vol-panel").textContent = vol(r.parts.panel?.volume);
    const p = state.params;
    status.innerHTML = `<b>${p.hpCount} HP</b> · ${p.frontHeight}/${p.rearHeight} mm · ${p.leftWall ? "asym" : "sym"} · built in ${(r.ms / 1000).toFixed(1)} s`;
    status.className = "src";
    readout();
    layout();
    if (firstBuild) { firstBuild = false; scene.frame(r.stats.width, r.stats.outerDepth, r.stats.height); }
  } catch (err) {
    status.textContent = "Build failed";
    status.className = "src bad";
    banner.querySelector("p")!.textContent = `The model could not be built: ${err instanceof Error ? err.message : String(err)}`;
    banner.classList.add("show");
  } finally {
    state.building = false;
    if (state.dirty) { state.dirty = false; rebuild(); }
  }
}

// ---- controls ------------------------------------------------------------------
const numeric: [string, keyof Required<CaseParamsInput> | "panelHp", boolean][] = [
  ["hp", "hpCount", false], ["front", "frontHeight", false], ["rear", "rearHeight", false],
  ["php", "panelHp", false], ["clr", "tabClearance", true],
];
for (const [id, key, float] of numeric) {
  const el = $<HTMLInputElement>(id);
  const apply = () => {
    const v = float ? parseFloat(el.value) : parseInt(el.value, 10);
    if (key === "panelHp") state.panelHp = v; else (state.params as Record<string, unknown>)[key] = v;
    showValues();
  };
  el.addEventListener("input", apply);
  el.addEventListener("change", () => { apply(); rebuild(); if (id === "hp") scene.frame(state.params.hpCount * HP, state.params.panelHeight + 8, Math.max(state.params.frontHeight, state.params.rearHeight)); });
}
for (const which of ["top", "bottom"] as const) {
  const size = $<HTMLInputElement>(`${which}-size`), style = $<HTMLSelectElement>(`${which}-lips`);
  const applySize = () => {
    const v = parseFloat(size.value), p = state.params;
    if (which === "top") { if (p.topLips === "chamfer") p.upperChamfer = v; else p.upperRound = v; }
    else { if (p.bottomLips === "chamfer") p.lowerChamfer = v; else p.lowerRound = v; }
    showValues();
  };
  size.addEventListener("input", applySize);
  size.addEventListener("change", () => { applySize(); rebuild(); });
  style.addEventListener("change", () => {
    if (which === "top") state.params.topLips = style.value as LipStyle; else state.params.bottomLips = style.value as LipStyle;
    size.value = String(lipSize(which));
    showValues(); rebuild();
  });
}
$<HTMLSelectElement>("left-end").addEventListener("change", (e) => {
  state.params.leftWall = (e.target as HTMLSelectElement).value === "wall";
  showValues(); rebuild();
});
$<HTMLInputElement>("explode").addEventListener("input", (e) => { state.explode = parseFloat((e.target as HTMLInputElement).value); showValues(); layout(); });
document.querySelectorAll<HTMLInputElement>("input[data-part]").forEach((cb) =>
  cb.addEventListener("change", () => { state.show[cb.dataset.part as keyof typeof state.show] = cb.checked; layout(); }));
document.querySelectorAll<HTMLButtonElement>(".views button").forEach((b) =>
  b.addEventListener("click", () => {
    const s = state.stats; if (!s) return;
    scene.frame(s.width, s.outerDepth, s.height, b.dataset.view as "iso" | "front" | "top" | "end");
  }));
$("reset").addEventListener("click", () => {
  state.params = { ...DEFAULTS }; state.panelHp = 6;
  const p = state.params;
  $<HTMLInputElement>("hp").value = String(p.hpCount); $<HTMLInputElement>("front").value = String(p.frontHeight); $<HTMLInputElement>("rear").value = String(p.rearHeight);
  $<HTMLSelectElement>("top-lips").value = p.topLips; $<HTMLSelectElement>("bottom-lips").value = p.bottomLips;
  $<HTMLInputElement>("top-size").value = String(lipSize("top")); $<HTMLInputElement>("bottom-size").value = String(lipSize("bottom"));
  $<HTMLSelectElement>("left-end").value = "cap"; $<HTMLInputElement>("php").value = "6"; $<HTMLInputElement>("clr").value = "0";
  showValues(); rebuild();
});

// ---- export ----------------------------------------------------------------------
const exportStatus = $("export-status");
for (const format of ["stl", "step"] as const) {
  $<HTMLButtonElement>(`export-${format}`).addEventListener("click", async () => {
    const part = $<HTMLSelectElement>("export-part").value as PartName;
    exportStatus.textContent = `Writing ${format.toUpperCase()}…`; exportStatus.className = "status";
    try {
      const r = (await ask({ kind: "export", part, format })) as Extract<Response, { kind: "file" }>;
      const url = URL.createObjectURL(new Blob([r.buffer], { type: "application/octet-stream" }));
      const a = document.createElement("a"); a.href = url; a.download = r.name; a.click();
      setTimeout(() => URL.revokeObjectURL(url), 10_000);
      exportStatus.textContent = `${r.name} (${(r.buffer.byteLength / 1048576).toFixed(2)} MiB)`; exportStatus.className = "status ok";
    } catch (err) {
      exportStatus.textContent = `Could not export: ${err instanceof Error ? err.message : String(err)}`;
    }
  });
}

// ---- go -------------------------------------------------------------------------
showValues();
rebuild();
