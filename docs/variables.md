# Onshape variables → `CaseParams`

The Part Studio's variable table (as shown in Onshape) against the port. "Used"
means a live sketch dimension or feature references the variable; several are
defined but never referenced, and the geometry shows what the sketches actually
drew.

| Onshape variable | value | `CaseParams` | port default | note |
|---|---|---|---|---|
| `HP_Count` | `#HP_Count0` | `hp_count` | 26 | configuration input |
| `HP` | 5.08 | `HP` (module constant) | 5.08 | |
| `CaseRearHeight` | `#RearHeight` | `rear_height` | 30 | configuration input |
| `CaseFrontHeight` | 33 | — | | **not used**: the front wall is dimensioned to the `Front_Height` configuration input (30); `front_height` |
| `CaseFrontBackThickness` | 4 | `wall_thickness` | 4 | |
| `CaseBottomThickness` | 4 | `bottom_thickness` | 4 | |
| `PanelHeight` | 129.5 | `panel_height` | 129.5 | clear width between the inner walls |
| `PanelThickness` | 2 | `panel_thickness` | 2 | depth of the panel recess |
| `PanelHoleVerticalInset` | 3 | `panel_hole_edge_inset` | 3 | |
| `RailBlockDepth` | 8 | `rail_depth` | **7.798472** | **not used**: the rail sketch carries a bare 7.798; the STEP export confirms it |
| `RailBlockHeight` | 16 | `rail_height` | **10** | **not used**: the block is drawn 10 tall; the STEP export confirms it |
| `RailBlockPanelInset` | 3 | `rail_inset` | 3 | bolt-slot axis from the inner wall |
| `RailBlockBoltWidth` | 3.2 | `rail_bolt_width` | 3.2 | |
| `RailBlockBoltDepth` | 8 | `rail_bolt_depth` | 8 | |
| `RailBlockNutWidth` | 5.8 | `rail_nut_width` | 5.8 | nut traps in the tab are cut `#RailBlockNutWidth - .1mm` |
| — | (undimensioned) | `rail_nut_slot_width` | **5.596945** | the rail's sliding-nut slot has no dimension; solved value, confirmed by the STEP |
| `RailBlockNutThickness` | 2.5 | `rail_nut_thickness` | 2.5 | |
| `RailBlockNutDepth` | 2 | `rail_nut_depth` | 2 | |
| `EndCapThickness` | `#CaseFrontBackThickness` | `end_cap_thickness` | 4 | |
| `EndCapTabThickness` | 5 | `end_cap_tab_thickness` | 5 | |
| `EndCapTabDepth` | `#BottomHoleInset + .7*#BoltCounterboreDiam` | `end_cap_tab_depth` (derived) | 8.2 | |
| `BoltThrougDiam` | 3.3 | `bolt_through_diam` | 3.3 | |
| `BoltCounterboreDiam` | 6 | `bolt_counterbore_diam` | 6 | |
| `BoltCounterboreThick` | 1.75 | `bolt_counterbore_depth` | 1.75 | |
| `BottomHoleInset` | 4 | `bottom_hole_inset` | 4 | screw axis from the case end |
| `BottomHoleSpacing` | 55 | `bottom_hole_spacing` | 55 | |
| `RearHoleSpacing` | 23 | `wall_hole_spacing` | 23 | used for both walls |
| `BaseCase` | measured, 137.5 | `outer_depth` (derived) | 137.5 | = `panel_height + 2 * wall_thickness` |
| `BaseCaseInset` | `#BaseCase - 3*#CaseFrontBackThickness` = 125.5 | — | | **not used** |
| `Railbolt_to_railbolt` | 123 | — | | **not used**; the rails are actually `panel_height - 2 * rail_inset` = 123.5 apart |
| `Rail_Length` | 56 | — | | **not used** |
| `BoltPlane_PanelEnd` | 3 | — | | **not used** |
| `UpperRoundDiam` | 2 | — | | **not used**: the fillet takes the `Upper_Round` configuration input (1); `upper_round` |
| `UpperChamfer` | 2 | — | | **not used**: the chamfer takes `Upper_Chamfer` (1); `upper_chamfer` |
| `LowerRoundDiam` | 0 | — | | drives only `Fillet 2`, which a 0 mm radius makes a no-op |
| `LowerChamfer` | 2 | — | | **not used**: the chamfer takes `Lower_Lip_Bevel` (1); `lower_chamfer` |

Configuration inputs not in the variable table: `Front_Height`, `Upper_Round`,
`Upper_Chamfer`, `Lower_Round`, `Lower_Lip_Bevel`, and the two lip-style enums —
`front_height`, `upper_round`, `upper_chamfer`, `lower_round`, `lower_chamfer`,
`top_lips`, `bottom_lips`.
