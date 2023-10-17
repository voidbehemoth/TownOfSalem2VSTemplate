# Town of Salem 2 Mod Template

An (unofficial) Visual Studio template for an unofficial modloader.

## Prerequisites

Requires [Visual Studio](https://visualstudio.microsoft.com/) and the [SalemModLoader](https://discord.gg/AdpRqzstfj) by Curtis. Knowledge of the C# language (and possibly the .NET framework) is strongly recommended. Only works on Windows.


## Creating A New Mod

1. Install all [prerequisites](#prerequisites) and [this template](#how-to-install).
2. Open Visual Studio.
3. Select File > New > Project in Visual Studio. This should open the project creation window.
4. Search for 'SalemModLoader Mod' in the search bar. Select it.
5. Hit 'Next.'
6. Fill out your project name and location. Keep in mind that the project name will be used as the default for a lot values.
7. Press 'Create.'
8. You made a mod! 

### Test That It Worked

1. Select Build > Build Solution in Visual Studio.
2. Open File Explorer. Navigate to where you created your mod.
3. Look for a folder called 'bin,' inside of it should be file called '\<yourmodname>.dll.'
4. Drag that file into your [mods folder](#where-is-the-mods-folder).

## How To Install

1. Install all [prerequisites](#prerequisites).
2. Download one of the releases (or [manually build it](#manual-installation).)
3. Navigate to your [project templates folder](#where-is-the-project-templates-folder).
4. Place the .zip file in said folder.

## Manual Installation

1. Download the repo.
2. Navigate to the ModTemplate folder.
3. Select all of its contents.
4. Select 'Send to' > 'Compressed (zipped) folder.'
5. Rename the zip file to your liking. That is the template.


## FAQ

### "Where is the project templates folder?"
If you are on Windows, it can be found at C:\Users\\<username>\Documents\Visual Studio \<version>\Templates\ProjectTemplates\

### "Where is the mods folder?"
Open Steam. Right click on Town of Salem 2. Select Manage > Browse local files. This should open up your game folder. Look for a folder called 'SalemModLoader,' and open it. Inside of that folder should be a 'Mods' folder.