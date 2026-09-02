# Port notes

How `eurorack_case/` relates to the Onshape source, and where it deliberately
differs. Read `port-feasibility.md` first for what the source contains.

## The parts

| part | Onshape origin |
|---|---|
| `case()` | `Case profile` + `Rail block profile` extruded `#HP_Count*#HP`; the C-cap end wall is discarded by `Split 1` / `Mirror 2`, which reflect one half of the shell onto the other, so the shell ends up open at both ends |
| `end_cap(end)` | `Endcap ex` (4 mm plate, `C-cap profile`) + `Endcap tab ex` (5 mm U-band, `End cap tab profile`, `#EndCapTabDepth` deep) with the nut traps from `Sketch 4`, `Rear Bolt Capture`, `Sketch 6` |
| `blank_panel(hp)` | `panel` / `panel thick` / the Ø3.2 hole feature — a 6 HP test panel |

Screws: `bottom hole setup 1/2`, `front hole setup`, `rear hole setup` and the
patterns that follow them. Ø3.3 through, Ø6 × 1.75 counterbore on the outside,
axis `#BottomHoleInset` (4 mm) in from each end so it lands inside the 8.2 mm
tab; a `#RailBlockNutWidth - .1mm` square trap 2 mm deep on the tab's inner face.

## Frame

X along the rails (0 → `width`), Y front (−) to rear (+) centred on the panel,
Z up with the wall tops at Z = 0. The source's Right-plane sketches map to the
YZ plane here; its `Rightplane` x is this Y and its y is this Z.

## Where the port differs from the source, on purpose

**Both ends are the same.** The source builds an integral end wall on one end,
then splits the shell at mid-length and mirrors the open half over it. The port
just builds the open shell — same result, none of the history.

**Bottom screws: three counterbores, centred.** The source patterns 3 through
holes but only 2 counterbores, and both patterns run one way from the floor's
midpoint rather than being centred, which puts one instance off the part. The
port cuts three counterbored screws at 0 and ±`bottom_hole_spacing` along the
floor. Same holes as the source at the default configuration.

**Wall screws: as many as fit.** The source fixes 1 screw on the front wall and
3 on the rear at `#RearHoleSpacing`, starting from the wall's mid-height. With
the default 30 mm rear wall the 2nd and 3rd rear holes fall off the part. The
port starts at mid-height, patterns at `wall_hole_spacing` in both directions,
and keeps every position whose nut trap fits in the tab's leg (between the
underside of the rail and the tab's floor). That gives 1 per wall at 30 mm and
3 at 80 mm, which is what the source's initial-guess geometry shows the author
working with.

**Upper chamfer on both top edges.** `Chamfer 1` in the source only selects the
front top edge; `Fillet 1` selects both. The port treats front and rear alike
for both styles.

**Minimum wall height is 21 mm, not 15.** Below panel recess + rail + floor +
tab (2 + 10 + 4 + 5) the end cap tab has nowhere to go and the source's own
geometry would self-intersect there. `CaseParams` refuses it.

**`Fillet 2` is dropped.** It is unconditional in the source but its radius is
`#LowerRoundDiam = 0 mm`, so it never produced geometry.

**Variables the source defines but never uses** — `RailBlockHeight` (16, the
rail is actually 10 tall), `Rail_Length`, `Railbolt_to_railbolt`, `BaseCase`,
`BaseCaseInset`, `UpperRoundDiam`, `LowerRoundDiam`, `UpperChamfer`,
`LowerChamfer`, `BoltPlane_PanelEnd` — are not carried over.

## Not ported

**The floor bracket** (`Sketch 2`, `Extrude 1–3`, `Sketch 8`, the mate
connectors and `Transform 1–4`): a 40 × 20 × 2 mm plate with two 6 mm steps and
two Ø2 holes, positioned on the case floor by mate connector. Its purpose is not
recorded, only two of its dimensions are constrained, and which sketch regions
get which step height is not recoverable from the export's region references.
If it is still wanted, describe it and it is a ten-line function.

**PSU mounts** and everything downstream of them (10 features) — retired in the
source, confirmed not wanted.

## Worth checking on the source design

**Rail spacing vs. real modules.** The bolt slots sit `rail_inset` = 3 mm from
the inner walls, so their axes are `panel_height − 6` = 123.5 mm apart. The
Eurorack standard is 122.5 mm (128.5 mm panel, holes 3 mm from the edge). A
standard module centred in the 129.5 mm recess therefore lands 0.5 mm outside a
3.2 mm slot. The port reproduces the source; the blank panel it builds matches
the rails, a bought module may not. Changing `panel_height` to 128.5 fixes both
the spacing and the recess width at once.

**Zero tab clearance.** The tab is modelled to the exact cavity size, as in the
source. `tab_clearance` shrinks it for a printable fit.
