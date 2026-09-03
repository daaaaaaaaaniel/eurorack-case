/** Page wiring: controls → worker → scene, and file downloads. */
import { Scene } from "./scene";
import type { BuiltMessage, PartName, Request, Response, Stats } from "./worker";
import { buildConfig, configText, parseConfig } from "./config";
import { CONFIG_MEMBER } from "./filename";
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
  const msg = `The modeling worker failed: ${ev.message || "unknown error"}`;
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
  const p = state.params;
  const t = p.endCapThickness;
  // an integral left wall takes the same 4 mm a cap would, so the assembled length is the
  // same either way; the case on its own is that much longer in the asymmetric variant
  $("w-with").innerHTML = `<b>${(s.width + 2 * t).toFixed(2)} mm</b> with end caps`;
  $("w-without").innerHTML = `<b>${(s.width + (p.leftWall ? t : 0)).toFixed(2)} mm</b>`;
  $("tilt").innerHTML = s.tiltDeg === 0
    ? "Panel is level"
    : `Panel tilts <b>${Math.abs(s.tiltDeg).toFixed(1)}°</b> toward ${s.tiltDeg > 0 ? "rear" : "front"}`;
  // one screw set per detachable end: both ends symmetric, the right end only asymmetric
  const ends = p.leftWall ? 1 : 2;
  const floor = 3 * ends, front = s.frontScrews * ends, rear = s.rearScrews * ends;
  $("r-screws").innerHTML = `${floor} floor · ${front} front · ${rear} rear (${floor + front + rear} total)`;
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
  const note = $("download-note");
  if (tickedParts().length === 0) {
    note.textContent = "No parts ticked. Config file only.";
    return;
  }
  const kinds = zipFormats().map((f) => f.toUpperCase() + "s");
  const names: string[] = [];
  if (state.show.case) names.push("case mid section");
  if (state.show.caps) names.push(state.params.leftWall ? "right end cap" : "two end caps");
  if (state.show.panel) names.push("blank panel");
  note.textContent = `ZIP contains ${kinds.join(" and ")} of ${names.join(", ")}, and config file.`;
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
    status.innerHTML = `<b>${p.hpCount} HP</b> · ${p.frontHeight}/${p.rearHeight} mm · ${p.leftWall ? "asymmetric" : "symmetric"}<span class="built"> built in ${(r.ms / 1000).toFixed(1)} s</span>`;
    status.className = "src";
    banner.classList.remove("show");
    readout();
    layout();
    if (firstBuild) { firstBuild = false; $("loading").hidden = true; scene.frame(r.stats.width, r.stats.outerDepth, r.stats.height); }
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

// A heading tip shows on hover or focus through CSS; a click pins it open until the
// next click elsewhere or Escape, for touch screens and anyone who wants to read slowly.
for (const tip of document.querySelectorAll<HTMLElement>(".tip")) {
  const button = tip.querySelector("button")!;
  const set = (open: boolean) => { tip.classList.toggle("open", open); button.setAttribute("aria-expanded", String(open)); };
  button.addEventListener("click", () => set(!tip.classList.contains("open")));
  document.addEventListener("click", (e) => { if (!tip.contains(e.target as Node)) set(false); });
  document.addEventListener("keydown", (e) => { if (e.key === "Escape") set(false); });
}

// ---- display colors --------------------------------------------------------------
// A picked color is written as an inline custom property on :root, so it overrides the
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

/** Show the stylesheet's own color in any swatch the user has not set. */
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

function serve(name: string, bytes: ArrayBuffer | string, type: string): void {
  const blob = new Blob([bytes], { type });
  const url = URL.createObjectURL(blob);
  const a = document.createElement("a"); a.href = url; a.download = name; a.click();
  setTimeout(() => URL.revokeObjectURL(url), 10_000);
  const size = blob.size >= 1048576 ? `${(blob.size / 1048576).toFixed(2)} MiB` : `${(blob.size / 1024).toFixed(1)} KiB`;
  exportStatus.textContent = `${name} (${size})`;
  exportStatus.className = "status ok";
}

/** Parts from the worker: a zip with config.json when `bundle` is set, else the one file bare. */
async function download(parts: PartName[], formats: ("stl" | "step")[], bundle: boolean): Promise<void> {
  exportStatus.textContent = "Writing…";
  exportStatus.className = "status";
  try {
    const r = (await ask({ kind: "export", parts, formats, bundle })) as Extract<Response, { kind: "file" }>;
    serve(r.name, r.buffer, "application/octet-stream");
  } catch (err) {
    exportStatus.textContent = `Could not export: ${err instanceof Error ? err.message : String(err)}`;
    exportStatus.className = "status";
  }
}

$("download").addEventListener("click", () => {
  const parts = tickedParts();
  // with nothing ticked there is no geometry to write, so the config comes down on its own
  if (parts.length === 0) serve(CONFIG_MEMBER, configText(buildConfig(state.params, state.panelHp)), "application/json");
  else download(parts, zipFormats(), true);
});
$("zip-format").addEventListener("change", downloadNote);
$("download-part").addEventListener("click", () => download(
  [$<HTMLSelectElement>("export-part").value as PartName],
  [$<HTMLSelectElement>("part-format").value as "stl" | "step"],
  false,
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
