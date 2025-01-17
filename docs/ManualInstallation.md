---
permalink: /ManualInstallation.html
title: Manual Installation
description: the flat-pack Kiea instructions, written in Kerbalese, unusally present
# layout: bare
tags: installation,directions,page,kerbal,ksp,zer0Kerbal,zedK
---

<!-- ManualInstallation.md v1.1.8.1
Solar Science (SOL)
created: 01 Oct 2019
updated: 29 Jul 2022 -->

<!-- based upon work by Lisias -->

# Solar Science (SOL)

[Home](./index.md)

Salutations! May the sunlight always be upon you!

This science addon that adds two Deep Space Solar Experiments (STEREO and SOHO) to Kerbal Space Program.

## Installation Instructions

### Using CurseForge/OverWolf app or CKAN

You should be all good! (check for latest version on CurseForge)

### If Downloaded from CurseForge/OverWolf manual download

To install, place the `SolarScience` folder inside your Kerbal Space Program's GameData folder:

* **REMOVE ANY OLD VERSIONS OF THE PRODUCT BEFORE INSTALLING**
  * Delete `<KSP_ROOT>/GameData/SolarScience`
* Extract the package's `SolarScience/` folder into your KSP's GameData folder as follows:
  * `<PACKAGE>/SolarScience` --> `<KSP_ROOT>/GameData/`
    * Overwrite any preexisting folder/file(s).
  * you should end up with `<KSP_ROOT>/GameData/SolarScience`

### If Downloaded from SpaceDock / GitHub / other

To install, place the `GameData` folder inside your Kerbal Space Program folder:

* **REMOVE ANY OLD VERSIONS OF THE PRODUCT BEFORE INSTALLING**
  * Delete `<KSP_ROOT>/GameData/SolarScience`
* Extract the package's `GameData/` folder into your KSP's root folder as follows:
  * `<PACKAGE>/GameData/` --> `<KSP_ROOT>`
    * Overwrite any preexisting file.
  * you should end up with `<KSP_ROOT>/GameData/SolarScience`

## The following file layout must be present after installation

```markdown
<KSP_ROOT>
  + [GameData]
    + [SolarScience]
      + [Assets]
        ...
      + [Flags]
        ...
      + [Localization]
        ...
      + [Parts]
        ...
      + [Plugins]
        ...
      + [Resources]
        ...
      * #.#.#.#.htm
      * Attributions.htm
      * changelog.md
      * GPL-3.0.txt
      * ManualInstallation.htm
      * readme.htm
      * SolarScience.version
    ...
  * KSP.log
    * ModuleManager.ConfigCache
  ...
```

### Dependencies

* none