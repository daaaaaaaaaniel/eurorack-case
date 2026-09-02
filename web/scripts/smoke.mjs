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
  console.log("volumes:", await evaluate("['vol-case','vol-caps','vol-panel'].map(i => document.getElementById(i).textContent).join(' / ')"));
  console.log("screws:", await evaluate("document.getElementById('r-screws').textContent"));

  await evaluate("const r = document.getElementById('rear'); r.value = 80; r.dispatchEvent(new Event('input')); r.dispatchEvent(new Event('change')); true");
  await sleep(300);
  await waitBuilt("rebuild at 30/80");
  console.log("screws:", await evaluate("document.getElementById('r-screws').textContent"));

  await evaluate("const l = document.getElementById('left-end'); l.value = 'wall'; l.dispatchEvent(new Event('change')); true");
  await sleep(300);
  await waitBuilt("rebuild asym");
  console.log("volumes:", await evaluate("['vol-case','vol-caps'].map(i => document.getElementById(i).textContent).join(' / ')"));

  // exports: intercept the download by stubbing the anchor click
  await evaluate("HTMLAnchorElement.prototype.click = function () { window.__dl = this.download; }; true");
  for (const fmt of ["stl", "step"]) {
    await evaluate(`document.getElementById('export-${fmt}').click(); true`);
    const t0 = Date.now();
    let s = "";
    while (Date.now() - t0 < 60000) { s = await evaluate("document.getElementById('export-status').textContent"); if (/MiB|Could not/.test(s)) break; await sleep(250); }
    console.log(`export ${fmt}: ${s}  file=${await evaluate("window.__dl")}`);
  }

  await evaluate("const e = document.getElementById('explode'); e.value = 0.5; e.dispatchEvent(new Event('input')); true");
  await sleep(500);
  const png = (await send("Page.captureScreenshot", { format: "png" })).result.data;
  writeFileSync(shot, Buffer.from(png, "base64"));
  console.log("screenshot:", shot);
  if (logs.length) console.log("console:", logs.join("\n"));
} finally {
  ws.close();
  proc.kill();
}
