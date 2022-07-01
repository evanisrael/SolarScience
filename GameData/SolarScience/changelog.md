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
  * make readonly
  *         private readonly string SunImageURL = "https://sdo.gsfc.nasa.gov/assets/img/latest/latest_1024_HMIB.jpg";
        private readonly string sunImageBackup = @"SolarScience/Plugins/Textures/latest_1024_HMIB";
        public readonly string blackImageURL = @"SolarScience/Plugins/Textures/Black";
        public readonly string Open_SFX = @"SolarScience/Plugins/Sounds/Open_KMI";
		
        private readonly Texture2D blackImage;


		// #SOL-closeBtn = close
### Status

* Issues
  * 

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
