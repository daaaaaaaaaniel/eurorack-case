/** three.js scene: Z-up like the CAD frame, flat-shaded parts with edge lines. */
import * as THREE from "three";
import { OrbitControls } from "three/examples/jsm/controls/OrbitControls.js";

import type { MeshPayload, PartName } from "./worker";

const tok = (name: string) => getComputedStyle(document.documentElement).getPropertyValue(name).trim();

export class Scene {
  readonly renderer: THREE.WebGLRenderer;
  readonly scene = new THREE.Scene();
  readonly camera: THREE.PerspectiveCamera;
  readonly controls: OrbitControls;
  readonly groups: Record<PartName, THREE.Group> = {
    case: new THREE.Group(), capL: new THREE.Group(), capR: new THREE.Group(), panel: new THREE.Group(),
  };
  private materials = {
    case: new THREE.MeshStandardMaterial({ flatShading: true, roughness: 0.75, metalness: 0.05 }),
    caps: new THREE.MeshStandardMaterial({ flatShading: true, roughness: 0.7, metalness: 0.05 }),
    panel: new THREE.MeshStandardMaterial({ flatShading: true, roughness: 0.55, metalness: 0.2 }),
    edge: new THREE.LineBasicMaterial({ transparent: true, opacity: 0.55 }),
  };
  private raf = 0;

  constructor(readonly canvas: HTMLCanvasElement) {
    this.renderer = new THREE.WebGLRenderer({ canvas, antialias: true });
    this.renderer.setPixelRatio(Math.min(window.devicePixelRatio || 1, 2));
    this.camera = new THREE.PerspectiveCamera(32, 1, 1, 5000);
    this.camera.up.set(0, 0, 1);
    this.controls = new OrbitControls(this.camera, canvas);
    this.controls.addEventListener("change", () => this.render());

    // physical light units (three >= r155): roughly pi times the old values
    this.scene.add(new THREE.HemisphereLight(0xffffff, 0x8a8f99, 2.4));
    const key = new THREE.DirectionalLight(0xffffff, 2.2); key.position.set(180, -220, 300); this.scene.add(key);
    const fill = new THREE.DirectionalLight(0xffffff, 0.9); fill.position.set(-200, 160, 120); this.scene.add(fill);
    for (const g of Object.values(this.groups)) this.scene.add(g);

    new ResizeObserver(() => this.resize()).observe(canvas);
    window.matchMedia("(prefers-color-scheme: dark)").addEventListener("change", () => this.applyTheme());
    new MutationObserver(() => this.applyTheme()).observe(document.documentElement, { attributes: true, attributeFilter: ["data-theme"] });
    this.applyTheme();
    this.resize();
  }

  applyTheme(): void {
    this.renderer.setClearColor(new THREE.Color(tok("--ground")));
    this.materials.case.color.set(tok("--case"));
    this.materials.caps.color.set(tok("--cap"));
    this.materials.panel.color.set(tok("--module"));
    this.materials.edge.color.set(tok("--edge"));
    this.render();
  }

  setPart(name: PartName, mesh: MeshPayload | undefined): void {
    const g = this.groups[name];
    while (g.children.length) {
      const c = g.children.pop() as THREE.Mesh | THREE.LineSegments;
      c.geometry.dispose();
    }
    if (!mesh) return;
    const geometry = new THREE.BufferGeometry();
    geometry.setAttribute("position", new THREE.BufferAttribute(mesh.positions, 3));
    geometry.setAttribute("normal", new THREE.BufferAttribute(mesh.normals, 3));
    geometry.setIndex(new THREE.BufferAttribute(mesh.indices, 1));
    const material = name === "case" ? this.materials.case : name === "panel" ? this.materials.panel : this.materials.caps;
    g.add(new THREE.Mesh(geometry, material));
    const lines = new THREE.BufferGeometry();
    lines.setAttribute("position", new THREE.BufferAttribute(mesh.lines, 3));
    g.add(new THREE.LineSegments(lines, this.materials.edge));
  }

  /** Move the caps and panel away from the shell. */
  explode(t: number): void {
    this.groups.capL.position.set(-45 * t, 0, 0);
    this.groups.capR.position.set(45 * t, 0, 0);
    this.groups.panel.position.set(0, 0, 40 * t);
    this.render();
  }

  frame(width: number, depth: number, height: number, view: "iso" | "front" | "top" | "end" = "iso"): void {
    const target = new THREE.Vector3(width / 2, 0, -height / 2);
    const extent = Math.max(width + 100, depth, height);
    const r = extent * 1.35 / Math.tan(this.camera.fov * Math.PI / 360) * 0.5 + 40;
    const presets = {
      iso: [-0.9, 1.05], front: [-Math.PI / 2, Math.PI / 2 - 0.02], top: [-Math.PI / 2, 0.02], end: [Math.PI, Math.PI / 2 - 0.02],
    } as const;
    const [theta, phi] = presets[view];
    this.camera.position.set(
      target.x + r * Math.sin(phi) * Math.cos(theta),
      target.y + r * Math.sin(phi) * Math.sin(theta),
      target.z + r * Math.cos(phi));
    this.controls.target.copy(target);
    this.controls.update();
    this.render();
  }

  resize(): void {
    const w = this.canvas.clientWidth, h = this.canvas.clientHeight;
    if (!w || !h) return;
    this.renderer.setSize(w, h, false);
    this.camera.aspect = w / h;
    this.camera.updateProjectionMatrix();
    this.render();
  }

  render(): void {
    if (this.raf) return;
    this.raf = requestAnimationFrame(() => { this.raf = 0; this.renderer.render(this.scene, this.camera); });
  }
}
