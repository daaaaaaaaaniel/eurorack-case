# Eurorack Case Preview — user manual

This is a guide to every control on the web page at
<https://daaaaaaaaaniel.github.io/eurorack-case/>. The page builds a 3D-printable
Eurorack case to your measurements, shows it to you in 3D, and hands you the
files to print. Nothing is uploaded: the model is built inside your browser.

The page has two halves. The **3D view** on the left shows the case. The
**side panel** on the right holds the controls, in the order described below.

---

## The 3D view

**LOADING…** appears in the middle of the view while the modeling engine
starts. That takes a few seconds the first time. Once the first case appears,
the page is ready.

**Mouse.** Drag with the left button to orbit around the case. Scroll to zoom.
Drag with the right button to pan. The reminder in the bottom-right corner,
"drag orbit · wheel zoom · right-drag pan", says the same thing.

**View buttons** (bottom-left): **Iso**, **Front**, **Top** and **End** snap
the camera to a standard angle and re-frame the whole case.

**The title block** (top-left) shows the page title, then a one-line summary
of the case now on screen, for example `26 HP · 30/30 mm · symmetric`, and under
that how long the last build took. While a rebuild is running the line reads
"Building…" with a pulsing dot. If a build fails, the reason appears here in red
and the previous case stays on screen.

Every change you make in the side panel rebuilds the case, which usually takes
one to three seconds.

---

## Display

Settings here change only how the preview looks. They have no effect on the
printed parts or on the downloaded files. The small circled **i** beside the
heading says the same thing when you hover over it or click it.

**Case color.** Click the swatch to open a color picker and choose a new color
for the case body. This color is also used for the page's highlights, such as
slider knobs and status text, so the panel matches the model.

**End cap color.** Click the swatch to pick the color of the end caps.

**Explode.** Drag the slider to the right to pull the parts apart so you can see
how they fit together. At 0 the case is assembled; at 1 it is fully spread out.
This only moves things in the preview.

---

## Parts

Three checkboxes, one per printable part, each with a color swatch and its
volume in cubic centimeters:

- **Case** — the mid section: the floor, the two long walls and the rails.
- **End caps** — the removable end plates (one or two, see *Side panels*).
- **Blank panel** — a plain module panel of the width set under *Parameters*,
  useful as a test print or to fill an empty slot.

Ticking a box **shows** that part in the 3D view **and includes it** in the zip
you get from Download. Unticking a box hides it and leaves it out of the zip.
The circled **i** beside the heading reminds you of this.

**Selected total** adds up the volume of the ticked parts. Multiply by your
filament's density to estimate material.

---

## Parameters

These sliders and dropdowns set the shape of the case. Every change rebuilds
the model.

**Side panels.** Choose how the ends of the case are made.

- *Symmetric (both detachable)* — both ends are separate end caps, screwed on.
  You print one case plus two caps.
- *Asymmetric (right detachable)* — the left end is a fixed wall printed as
  part of the case; only the right end is a removable cap. You print one case
  plus one cap. Choose this if you want a case that can only be opened from
  one side, or to save a part.

**Width.** The width of the case in HP (horizontal pitch, the Eurorack unit:
1 HP = 5.08 mm). Range 2 to 168 HP. Two lines under the slider give the result
in millimeters:

- the first is the length of the case mid section on its own;
- the second, marked "with end caps", is the assembled length including the
  end caps.

**Front height** and **Rear height.** The height of the front and rear walls in
millimeters, 21 to 200 mm each. Set them equal for a flat case, or make the rear
taller to tilt the modules toward you. Under *Rear height* a line reports the
result: "Panel is level" or "Panel tilts 20.0° toward front".

**Top lips** and **Bottom lips.** The shape of the edges along the top of the
walls and along the bottom of the case. Each has a dropdown and a size slider.

- *Round* — a rounded edge, with the slider setting its radius.
- *Chamfer* — a 45° flat cut, with the slider setting its size.
- *Sharp* — a plain square edge. The slider is greyed out because there is
  nothing to size.

Top lips run from 0.5 to 3.5 mm; bottom lips from 0.5 to 10 mm. Very large lips
can be impossible to build, in which case the title block says so and the
previous case stays on screen; choose a smaller size.

**Tab clearance.** Each end cap has a tab that slides into the case. This slider
shrinks the tab by 0 to 0.6 mm to give a looser fit. Leave it at 0 for a
snug fit and increase it if your printer makes the tab too tight.

**Blank panel.** The width of the blank panel part in HP, from 2 HP up to the
width of the case.

**Reset to defaults.** Puts every parameter back to its starting value
(26 HP, 30 mm front and rear, 1 mm round lips, symmetric, 6 HP panel) and
restores the default display colors.

---

## Assembly information

**Screws.** How many M3 screws hold the end caps on, for the whole case as set
now, split into floor, front and rear positions, with the total in brackets.
The number changes with the wall heights, because taller walls take more
screws, and with *Side panels*, because a symmetric case has two detachable ends
and needs twice as many. Each screw goes into a square nut trapped in the end
cap's tab, so you need as many **M3 square nuts** as screws.

---

## Export

**Format.** What kind of file to write for each part:

- *STL* — a mesh, for slicing and printing.
- *STEP* — an exact solid, for opening in CAD software.
- *Both* — one of each per part.

**Download.** Writes a zip file named `case.zip` containing every part ticked
under *Parts*, in the chosen format(s), plus a `config.json` recording the
settings that produced them. The note under the button always spells out what
you will get, for example "ZIP contains STLs of case mid section, two end caps,
blank panel, and config file."

If **no parts are ticked**, the note reads "No parts ticked. Config file only."
and the button downloads just `config.json`, on its own, as a plain JSON file.

Files inside the zip are named for the part and the settings that shape it,
so files from different cases never clash:

| file | meaning |
| --- | --- |
| `case_26hp_30mm-front_45mm-rear.stl` | case mid section, 26 HP, 30 mm front, 45 mm rear |
| `capL_30mm-front_45mm-rear.stl` | left end cap |
| `capR_30mm-front_45mm-rear.stl` | right end cap |
| `panel_6hp.stl` | 6 HP blank panel |
| `config.json` | the settings |

End caps carry no HP because their shape does not depend on the case width.

**More options** (click to expand). For downloading one part by itself:

- **Part** — which part to download: *Case*, *End cap, left*, *End cap, right*
  or *Blank panel*. The left cap is unavailable in the asymmetric variant,
  because that end is a fixed wall.
- **Format** — *STL* or *STEP*.
- **Download** — saves that one part as a bare file. No zip, no config file.

The status text beside a Download button shows the name and size of the file
that was just written, or an error if something went wrong.

---

## Config

**Import config.** Opens a file picker. Choose a `config.json` saved by this
page, either the one inside a downloaded `case.zip` (unzip it first) or one
downloaded on its own. Every control moves to the values in the file and the
case is rebuilt, so you can come back months later and reprint the same case,
or nudge one setting and reprint.

Only `.json` files are accepted. If the file is not one of ours, the status
text says so and nothing changes. If a value is missing, out of range or
mis-typed, the page corrects it to the nearest allowed value and lists each
correction in the status text, so you can see what was changed. The saved file
holds only the settings on this page; everything else about the case follows
the current model.

The file is plain text and can be edited by hand. It looks like this:

```json
{
  "format": "eurorack-case",
  "version": 1,
  "generated": "2026-09-03T02:25:00.000Z",
  "source": "https://github.com/daaaaaaaaaniel/eurorack-case",
  "parameters": {
    "hpCount": 26,
    "frontHeight": 30,
    "rearHeight": 30,
    "topLips": "round",
    "upperRound": 1,
    "upperChamfer": 1,
    "bottomLips": "round",
    "lowerRound": 1,
    "lowerChamfer": 1,
    "leftWall": false,
    "tabClearance": 0,
    "blankPanelHp": 6
  }
}
```

`leftWall: true` means the asymmetric variant. `topLips` and `bottomLips` are
`"round"`, `"sharp"` or `"chamfer"`, and the matching size is read from
`upperRound`/`upperChamfer` or `lowerRound`/`lowerChamfer`.

---

## Credits

Click **Credits** to expand the list of who made the case and the page.
"Supported by Synth Library NYC" is always shown, and links to their site.

---

## Printing the parts

1. Tick the parts you need, choose *STL*, and press **Download**.
2. Unzip `case.zip` and slice each `.stl`. Units are millimeters.
3. Keep `config.json` with your prints. Import it later to reprint or adjust.
4. Fit an M3 square nut into each trap in the end cap tabs, slide the caps on,
   and drive an M3 screw through each hole in the case. The *Assembly
   information* section tells you how many of each you need.
