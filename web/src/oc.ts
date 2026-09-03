/**
 * Start OpenCascade and hand it to replicad. Call once, before any modeling.
 *
 * In Node the wasm is read from the package directory; in the browser Vite
 * serves it (import the `.wasm?url` and pass it through `locateFile`).
 */
import opencascade from "replicad-opencascadejs";
import { setOC } from "replicad";

let ready: Promise<void> | null = null;

export function initOC(locateFile?: (file: string, dir: string) => string): Promise<void> {
  if (!ready) {
    ready = (opencascade as unknown as (opts?: object) => Promise<unknown>)(locateFile ? { locateFile } : undefined)
      .then((oc) => { setOC(oc as Parameters<typeof setOC>[0]); });
  }
  return ready;
}
