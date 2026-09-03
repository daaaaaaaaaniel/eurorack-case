/** Page wiring: controls → worker → scene, and file downloads. */
import { Scene } from "./scene";
import type { BuiltMessage, PartName, Request, Response, Stats } from "./worker";
import { parseConfig } from "./config";
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
  volumes: {} as Partial<Record<PartName, number>>,
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

/** Per-part volumes and the total over the parts currently shown. */
function showVolumes(): void {
  const v = state.volumes;
  const cm3 = (mm3: number | undefined) => (mm3 === undefined ? "" : `${(mm3 / 1000).toFixed(1)} cm\u00b3`);
  const caps = v.capL === undefined && v.capR === undefined ? undefined : (v.capL ?? 0) + (v.capR ?? 0);
  $("vol-case").textContent = cm3(v.case);
  $("vol-caps").textContent = cm3(caps);
  $("vol-panel").textContent = cm3(v.panel);
  const shown = [
    state.show.case ? v.case : undefined,
    state.show.caps ? caps : undefined,
    state.show.panel ? v.panel : undefined,
  ].filter((x): x is number => x !== undefined);
  $("vol-total").textContent = shown.length ? cm3(shown.reduce((a, b) => a + b, 0)) : "";
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

/** The ticked parts, in the order they are listed. */
function tickedParts(): PartName[] {
  const parts: PartName[] = [];
  if (state.show.case) parts.push("case");
  if (state.show.caps) {
    if (!state.params.leftWall) parts.push("capL");
    parts.push("capR");
  }
  if (state.show.panel) parts.push("panel");
  return parts;
}

const zipFormats = (): ("stl" | "step")[] =>
  $<HTMLSelectElement>("zip-format").value.split(",") as ("stl" | "step")[];

/** Say what pressing Download will actually produce. */
function downloadNote(): void {
  const n = tickedParts().length;
  const note = $("download-note");
  const button = $<HTMLButtonElement>("download");
  button.disabled = n === 0;
  if (n === 0) {
    note.textContent = "Nothing is ticked under Parts.";
    return;
  }
  const formats = zipFormats();
  const kinds = formats.map((f) => f.toUpperCase() + "s");
  const named = kinds.length === 2 ? `${kinds[0]} and ${kinds[1]}` : kinds[0];
  const parts = `${n} ticked ${n === 1 ? "part" : "parts"}`;
  // one part in one format comes down bare, so it carries no configuration
  note.textContent = n * formats.length === 1
    ? `${kinds[0].slice(0, -1)} of the one ticked part, on its own.`
    : `${named} of the ${parts}, plus a config file.`;
}

function layout(): void {
  scene.groups.case.visible = state.show.case;
  scene.groups.capL.visible = state.show.caps && !state.params.leftWall;
  scene.groups.capR.visible = state.show.caps;
  scene.groups.panel.visible = state.show.panel;
  scene.explode(state.explode);
  showVolumes();
  downloadNote();
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
    state.volumes = {};
    for (const name of ["case", "capL", "capR", "panel"] as PartName[]) state.volumes[name] = r.parts[name]?.volume;
    const p = state.params;
    status.innerHTML = `<b>${p.hpCount} HP</b> · ${p.frontHeight}/${p.rearHeight} mm · ${p.leftWall ? "asymmetric" : "symmetric"} · built in ${(r.ms / 1000).toFixed(1)} s`;
    status.className = "src";
    banner.classList.remove("show");
    readout();
    layout();
    if (firstBuild) { firstBuild = false; scene.frame(r.stats.width, r.stats.outerDepth, r.stats.height); }
  } catch (err) {
    // keep the last good model on screen; say what went wrong where the build time normally goes
    const message = err instanceof Error ? err.message : String(err);
    status.textContent = message.replace(/\.\s*$/, "");
    status.className = "src bad";
    if (firstBuild) { banner.querySelector("p")!.textContent = `The model could not be built: ${message}`; banner.classList.add("show"); }
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

// ---- display colours -------------------------------------------------------------
// A picked colour is written as an inline custom property on :root, so it overrides the
// stylesheet's light and dark values and every rule reading that token follows — the
// panel swatches and the accent from CSS, the three.js materials from applyTheme().
const SWATCHES = { "col-case": ["--case", "--accent"], "col-cap": ["--cap"] } as const;
type SwatchId = keyof typeof SWATCHES;
const picked = new Set<SwatchId>();

const token = (name: string) => getComputedStyle(document.documentElement).getPropertyValue(name).trim();
const rgba = (hex: string, a: number) => {
  const n = parseInt(hex.slice(1), 16);
  return `rgba(${(n >> 16) & 255}, ${(n >> 8) & 255}, ${n & 255}, ${a})`;
};

function applySwatch(id: SwatchId, hex: string | null): void {
  const root = document.documentElement.style;
  for (const name of SWATCHES[id]) {
    if (hex) root.setProperty(name, hex); else root.removeProperty(name);
  }
  if (id === "col-case") {
    if (hex) root.setProperty("--thumb-ring", rgba(hex, 0.24)); else root.removeProperty("--thumb-ring");
  }
  if (hex) picked.add(id); else picked.delete(id);
  scene.applyTheme();
}

/** Show the stylesheet's own colour in any swatch the user has not set. */
function syncSwatches(): void {
  for (const id of Object.keys(SWATCHES) as SwatchId[]) {
    if (picked.has(id)) continue;
    const value = token(SWATCHES[id][0]);
    if (/^#[0-9a-f]{6}$/i.test(value)) $<HTMLInputElement>(id).value = value;
  }
}

for (const id of Object.keys(SWATCHES) as SwatchId[]) {
  $<HTMLInputElement>(id).addEventListener("input", (e) => applySwatch(id, (e.target as HTMLInputElement).value));
}
window.matchMedia("(prefers-color-scheme: dark)").addEventListener("change", () => setTimeout(syncSwatches));
document.querySelectorAll<HTMLInputElement>("input[data-part]").forEach((cb) =>
  cb.addEventListener("change", () => { state.show[cb.dataset.part as keyof typeof state.show] = cb.checked; layout(); }));
document.querySelectorAll<HTMLButtonElement>(".views button").forEach((b) =>
  b.addEventListener("click", () => {
    const s = state.stats; if (!s) return;
    scene.frame(s.width, s.outerDepth, s.height, b.dataset.view as "iso" | "front" | "top" | "end");
  }));
/** Put every control where the state says it should be. */
function syncControls(): void {
  const p = state.params;
  $<HTMLInputElement>("hp").value = String(p.hpCount);
  $<HTMLInputElement>("front").value = String(p.frontHeight);
  $<HTMLInputElement>("rear").value = String(p.rearHeight);
  $<HTMLSelectElement>("top-lips").value = p.topLips;
  $<HTMLSelectElement>("bottom-lips").value = p.bottomLips;
  $<HTMLInputElement>("top-size").value = String(lipSize("top"));
  $<HTMLInputElement>("bottom-size").value = String(lipSize("bottom"));
  $<HTMLSelectElement>("left-end").value = p.leftWall ? "wall" : "cap";
  $<HTMLInputElement>("php").value = String(state.panelHp);
  $<HTMLInputElement>("clr").value = String(p.tabClearance);
}

$("reset").addEventListener("click", () => {
  state.params = { ...DEFAULTS }; state.panelHp = 6;
  syncControls();
  for (const id of Object.keys(SWATCHES) as SwatchId[]) applySwatch(id, null);
  syncSwatches();
  showValues(); rebuild();
});

// ---- export ----------------------------------------------------------------------
const exportStatus = $("export-status");

async function download(parts: PartName[], formats: ("stl" | "step")[]): Promise<void> {
  exportStatus.textContent = "Writing…";
  exportStatus.className = "status";
  try {
    const r = (await ask({ kind: "export", parts, formats })) as Extract<Response, { kind: "file" }>;
    const url = URL.createObjectURL(new Blob([r.buffer], { type: "application/octet-stream" }));
    const a = document.createElement("a"); a.href = url; a.download = r.name; a.click();
    setTimeout(() => URL.revokeObjectURL(url), 10_000);
    exportStatus.textContent = `${r.name} (${(r.buffer.byteLength / 1048576).toFixed(2)} MiB)`;
    exportStatus.className = "status ok";
  } catch (err) {
    exportStatus.textContent = `Could not export: ${err instanceof Error ? err.message : String(err)}`;
    exportStatus.className = "status";
  }
}

$("download").addEventListener("click", () => download(tickedParts(), zipFormats()));
$("zip-format").addEventListener("change", downloadNote);
$("download-part").addEventListener("click", () => download(
  [$<HTMLSelectElement>("export-part").value as PartName],
  [$<HTMLSelectElement>("part-format").value as "stl" | "step"],
));

// ---- config ----------------------------------------------------------------------
const configStatus = $("config-status");
const configFile = $<HTMLInputElement>("config-file");
$("import-config").addEventListener("click", () => configFile.click());
configFile.addEventListener("change", async () => {
  const file = configFile.files?.[0];
  configFile.value = "";               // so the same file can be picked twice
  if (!file) return;
  configStatus.className = "status";
  try {
    const { parameters, warnings } = parseConfig(await file.text());
    const { blankPanelHp, ...rest } = parameters;
    state.params = { ...DEFAULTS, ...rest };
    state.panelHp = blankPanelHp;
    syncControls();
    showValues();
    await rebuild();
    configStatus.textContent = warnings.length
      ? `Loaded with ${warnings.length} correction${warnings.length === 1 ? "" : "s"}: ${warnings.join("; ")}`
      : `Loaded ${file.name}`;
    if (!warnings.length) configStatus.className = "status ok";
    scene.frame(state.params.hpCount * HP, state.params.panelHeight + 8,
      Math.max(state.params.frontHeight, state.params.rearHeight));
  } catch (err) {
    configStatus.textContent = `Could not read that file: ${err instanceof Error ? err.message : String(err)}`;
  }
});

// ---- go -------------------------------------------------------------------------
syncSwatches();
showValues();
downloadNote();
rebuild();
