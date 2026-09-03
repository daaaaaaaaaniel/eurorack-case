#!/usr/bin/env node
/**
 * Drive the built app in headless Chromium over the DevTools protocol:
 * wait for the first real build, change a parameter, rebuild, export, and
 * take a screenshot. Needs a preview server (`npm run preview`) and a
 * Chromium binary.
 *
 *   node scripts/smoke.mjs http://localhost:4173/eurorack-case/ /path/to/chrome out.png
 */
import { spawn } from "node:child_process";
import { writeFileSync } from "node:fs";

const [url, chrome, shot] = process.argv.slice(2);
const port = 9333;
const proc = spawn(chrome, [
  "--headless=new", "--no-sandbox", "--disable-gpu", "--use-angle=swiftshader", "--enable-unsafe-swiftshader",
  "--hide-scrollbars", "--window-size=1400,900", `--remote-debugging-port=${port}`, "about:blank",
], { stdio: "ignore" });
const sleep = (ms) => new Promise((r) => setTimeout(r, ms));

async function target() {
  for (let i = 0; i < 50; i++) {
    try {
      const r = await fetch(`http://127.0.0.1:${port}/json/new?${encodeURIComponent(url)}`, { method: "PUT" });
      return await r.json();
    } catch { await sleep(200); }
  }
  throw new Error("chrome did not come up");
}

const t = await target();
const ws = new WebSocket(t.webSocketDebuggerUrl);
await new Promise((r) => (ws.onopen = r));
let id = 0;
const waits = new Map();
const logs = [];
ws.onmessage = (ev) => {
  const m = JSON.parse(ev.data);
  if (m.id && waits.has(m.id)) { waits.get(m.id)(m); waits.delete(m.id); }
  if (m.method === "Runtime.exceptionThrown") logs.push("EXC " + JSON.stringify(m.params.exceptionDetails.exception?.description ?? m.params.exceptionDetails.text));
  if (m.method === "Runtime.consoleAPICalled" && m.params.type === "error") logs.push("ERR " + m.params.args.map((a) => a.value ?? a.description).join(" "));
};
const send = (method, params = {}) => new Promise((r) => { const i = ++id; waits.set(i, r); ws.send(JSON.stringify({ id: i, method, params })); });
const evaluate = async (expression) => (await send("Runtime.evaluate", { expression, awaitPromise: true, returnByValue: true })).result?.result?.value;

await send("Runtime.enable");
const status = () => evaluate("document.getElementById('status').textContent");
const waitBuilt = async (label, timeout = 120000) => {
  const t0 = Date.now();
  while (Date.now() - t0 < timeout) {
    const s = await status();
    if (/built in/.test(s)) { console.log(`${label}: ${s}  (${((Date.now() - t0) / 1000).toFixed(1)} s wall)`); return s; }
    if (/failed/.test(s)) throw new Error(`${label}: ${s} ${logs.join(" | ")}`);
    await sleep(500);
  }
  throw new Error(`${label}: timed out at "${await status()}" ${logs.join(" | ")}`);
};

try {
  await waitBuilt("first build");
  const vols = () => evaluate("['vol-case','vol-caps','vol-panel','vol-total'].map(i => document.getElementById(i).textContent).join(' / ')");
  console.log("volumes:", await vols());
  console.log("screws:", await evaluate("document.getElementById('r-screws').textContent"));

  // the total follows the part checkboxes without a rebuild
  await evaluate("const b = document.querySelector('input[data-part=panel]'); b.checked = false; b.dispatchEvent(new Event('change')); true");
  console.log("volumes without the panel:", await vols());
  await evaluate("const b = document.querySelector('input[data-part=panel]'); b.checked = true; b.dispatchEvent(new Event('change')); true");

  await evaluate("const r = document.getElementById('rear'); r.value = 80; r.dispatchEvent(new Event('input')); r.dispatchEvent(new Event('change')); true");
  await sleep(300);
  await waitBuilt("rebuild at 30/80");
  console.log("screws:", await evaluate("document.getElementById('r-screws').textContent"));

  await evaluate("const l = document.getElementById('left-end'); l.value = 'wall'; l.dispatchEvent(new Event('change')); true");
  await sleep(300);
  await waitBuilt("rebuild asym");
  console.log("volumes:", await vols());

  // a picked color overrides the stylesheet for both the panel and the 3D materials
  await evaluate("const c = document.getElementById('col-case'); c.value = '#3aa675'; c.dispatchEvent(new Event('input')); true");
  console.log("case color:", await evaluate("getComputedStyle(document.documentElement).getPropertyValue('--case').trim() + ' accent ' + getComputedStyle(document.documentElement).getPropertyValue('--accent').trim()"));

  // exports: intercept the download by stubbing the anchor click, and keep the bytes
  await evaluate(`HTMLAnchorElement.prototype.click = function () {
    window.__dl = this.download;
    window.__blob = fetch(this.href).then(r => r.arrayBuffer());
  }; true`);
  const saved = async (label) => {
    const t0 = Date.now();
    let s = "";
    while (Date.now() - t0 < 60000) { s = await evaluate("document.getElementById('export-status').textContent"); if (/MiB|Could not/.test(s)) break; await sleep(250); }
    console.log(`${label}: ${s}  file=${await evaluate("window.__dl")}`);
    if (/Could not/.test(s)) throw new Error(`${label} failed: ${s}`);
    return s;
  };

  console.log("download note:", await evaluate("document.getElementById('download-note').textContent"));
  await evaluate("const f = document.getElementById('zip-format'); f.value = 'stl,step'; f.dispatchEvent(new Event('change')); true");
  console.log("download note:", await evaluate("document.getElementById('download-note').textContent"));
  await evaluate("document.getElementById('download').click(); true");
  await saved("zip, both formats");
  // read the member names straight out of the archive's central directory
  const members = await evaluate(`window.__blob.then(b => {
    const v = new DataView(b), out = [];
    for (let i = 0; i < v.byteLength - 3; i++) {
      if (v.getUint32(i, true) === 0x02014b50) {
        const n = v.getUint16(i + 28, true);
        out.push(new TextDecoder().decode(new Uint8Array(b, i + 46, n)));
      }
    }
    return out.join(' ');
  })`);
  console.log("zip holds:", members);

  // one part in one format comes down bare
  await evaluate("const p = document.getElementById('export-part'); p.value = 'capR'; true");
  await evaluate("document.getElementById('download-part').click(); true");
  await saved("single part");

  // a configuration round trip: write one by hand, load it, watch the page follow
  await evaluate(`(() => {
    const cfg = { format: "eurorack-case", version: 1, parameters: { hpCount: 42, frontHeight: 25, rearHeight: 60, topLips: "chamfer", upperChamfer: 2, leftWall: false, blankPanelHp: 8 } };
    const file = new File([JSON.stringify(cfg)], "config.json", { type: "application/json" });
    const dt = new DataTransfer(); dt.items.add(file);
    const input = document.getElementById("config-file");
    input.files = dt.files;
    input.dispatchEvent(new Event("change"));
    return true;
  })()`);
  // wait for the imported case itself, not whatever was on screen before
  const t1 = Date.now();
  while (Date.now() - t1 < 60000) {
    if (/42 HP.*built in/.test(await status())) break;
    await sleep(250);
  }
  console.log("after importing a config:", await status());
  const cs = await evaluate("document.getElementById('config-status').textContent");
  console.log("config status:", cs);
  if (!/Loaded/.test(cs)) throw new Error(`config import did not report success: "${cs}"`);
  console.log("controls now:", await evaluate("[['hp',26],['front',0],['rear',0],['php',0]].map(([i]) => i + '=' + document.getElementById(i).value).join(' ') + ' lips=' + document.getElementById('top-lips').value"));

  // the Display tip pins open on click, and a click elsewhere closes it
  await evaluate("document.getElementById('display-tip').click(); true");
  const tipState = () => evaluate("(() => { const t = document.getElementById('display-tip-text'); return getComputedStyle(t).display + ': ' + t.textContent; })()");
  console.log("display tip:", await tipState());
  if (!/^block: Display settings only affect/.test(await tipState())) throw new Error(`display tip did not open: "${await tipState()}"`);

  await evaluate("const e = document.getElementById('explode'); e.value = 0.5; e.dispatchEvent(new Event('input')); true");
  await sleep(500);
  const png = (await send("Page.captureScreenshot", { format: "png" })).result.data;
  writeFileSync(shot, Buffer.from(png, "base64"));
  console.log("screenshot:", shot);
  await evaluate("document.body.click(); true");
  if (!/^none:/.test(await tipState())) throw new Error("display tip did not close");

  // and the rest of the panel, with the extra download options open
  await evaluate("document.querySelector('details.more').open = true; document.querySelector('aside').scrollTop = 1e6; true");
  await sleep(300);
  const panelShot = shot.replace(/\.png$/, "-panel.png");
  writeFileSync(panelShot, Buffer.from((await send("Page.captureScreenshot", { format: "png" })).result.data, "base64"));
  console.log("screenshot:", panelShot);
  if (logs.length) console.log("console:", logs.join("\n"));
} finally {
  ws.close();
  proc.kill();
}
