# Changelog  
  
| modName    | Solar Science (SOL)                                               |
| ---------- | ----------------------------------------------------------------- |
| license    | GPL-3.0                                                           |
| author     | Snoopy20111 and zer0Kerbal                                        |
| forum      | (https://forum.kerbalspaceprogram.com/index.php?/topic/192489-*/) |
| github     | (https://github.com/zer0Kerbal/zer0Kerbal/SolarScience)           |
| curseforge | (https://www.curseforge.com/kerbal/ksp-mods/SolarScience)         |
| spacedock  | (https://spacedock.info/mod/811)                                  |
| ckan       | SolarScience                                                      |

## Version 1.3.0.0 - `<Let the Sun Shine on KSP`>

* 30 Jun 2020
* Released for KSP 1.12.3

### Code

* Code
  * recompile for KSP 1.12.3
  * using .net 4.6.1
  * remove
    * [InstallChecker.cs]
    * [AssemblyVersion.tt]
    * [Log.cs]
  * update [Version.tt]
  * make readonly
    * string SunImageURL
    * string sunImageBackup
    * string blackImageURL
    * string Open_SFX
    * Texture2D blackImage;

### Localization

* Add
  * [readme.md] v2.1.2.0
  * [quickstart.md] v1.0.1.1
* closes #5 - English <us-en.cfg>
* updates #4 - Localization - Master
* Scrap Squad dictionary
  * #SOL-closeBtn = #autoLOC_149410 // close

### License

* Update to GPL-3.0
  * was Expat/MIT
* closes #29 - Update License to GPLv3

### docs/

* Add
  * [Attribution.md] v1.0.6.0
  * [ManualInstallation.md] v1.1.7.0
  * [404-petunia.md]
  * [LegalMumboJumbo.md] v1.0.5.0
  * [Localizations.md] v1.1.3.1
  * [Notices.md] v1.0.0.0
  * [Why-not.md]
  * [_config.yml]
* closes #29 - add docs/

### Convert Changelog

* Convert from .cfg to md
* Add missing information for earlier releases
* closes #33 - Convert Changelog

### Status

* Issues
  * closes #6 - ImgBot
  * closes# 23 - Solar Science (SOL) 1.3.0.0-release - <`Let the Sun Shine on KSP`> edition
  * closes# 24 - 1.3.0.0 Verify Legal Mumbo Jumbo
  * closes# 25 - 1.3.0.0 Update Documentation
  * closes# 26 - 1.3.0.0 Update Social Media

---

## Version 1.2.0.0 - `<Praise Snoopy 20111!>`

* Released for KSP 1.7.3
* 18 Mar 2020

### Adoption by zer0Kerbal
  
### Initial release

### License

* license changed by original author to MIT (thank you @Snoopy 20111 )

### Code

* compiled with .NET 3.5
* Internal code rewrite to improve maintainability
  * combined two .dll's into one - still some optimization to be had
  * added [Version.TT] and [AssemblyVersion.TT]
  * added [InstallChecker.cs] 2.0.0.0
  * added [Log.cs]
  * lots of little changes

### Localization

* added
  * Localization to code
  * Localization to parts
  * [en-us.cfg]

### Assets

* moved
  * sounds into Plugins/
  * textures into Plugins/

### Deployment

* added
  * automated backend processes
  * support infrastructure
  * json's
* Updated
  * GitHub
  * SpaceDock
  * Curseforge
* New
  * forum thread
* Converted
  * Kerbal Changelog

### Parts

* Reformatted
  * all part cfg files

---

### Version = 1.1.1.0

* Released on 2020-03-17
* for Kerbal Space Program 1.9.1

* License changed in preparation for handing the project over to a new author
  * Updated the license
    * from Creative Commons to MIT

---

### Version = 1.1.0.0

* Released on  2018-08-03
* for Kerbal Space Program 1.9.1

* Biggest update since 1.0!
  * Running the experiment loads up the most recent image from the SOHO or STEREO spacecraft for the KMI and STEREO parts, respectively
  * If you're not connected to the internet, there is a backup image
  * Added original sound effects
  * New experiment descriptions

---

### Version = 1.0.6.0

* Released on  2017-05-31
* for Kerbal Space Program 1.4.3

* Grammar changes in some item descriptions
* Otherwise identical to 1.05

---

### Version = 1.0.5.0

* Released on 2016-11-05
* for Kerbal Space Program 1.2.2

* No longer can you just be close to the sun and run the experiment...
* you must also make sure your craft is steady and that the right end is pointed at Kerbol!
* Textures have been converted to DDS, making Solar Science load in the blink of an eye!

---

### Version = 1.0.4.0

* Released on  2016-11-05
* for Kerbal Space Program 1.1.3

* Rebuilt code to work in KSP 1.1
* Moved instruments in the tech tree to make a bit more sense
* Made instruments heavier

---

### Version = 1.0.3.0

* Released on  2016-06-30
* for Kerbal Space Program 1.0

* THIS VERSION WORKS FOR KSP VERSIONS 1.0.5 BACK THROUGH .23.
  * It may also work further back than that, but in that case use at your own risk.

* Besides a few minor changes for polish
  * this version is identical to 1.0.
  * clearing useless files
  * editing a flag or two
  * item values
  * etc
* If you're looking for Solar Science 1.0 through 1.02
* I removed them because people were downloading them very regularly, for some reason, even though this one is better.

---

### Version = 1.0.2.0

* no changelog provided

---

### Version = 1.0.1.0

* no changelog provided

---

### Version = 1.0.0.0

* no changelog provided

---
