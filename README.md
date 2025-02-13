# Desktop Mate - NoSteam  [![Downloads](https://img.shields.io/github/downloads/Rafacasari/DesktopMate-NoSteam/total?color=blue)](https://github.com/Rafacasari/DesktopMate-NoSteam/releases/latest) [![Current Version](https://img.shields.io/github/v/release/rafacasari/DesktopMate-NoSteam?color=gren&label=version)](https://github.com/Rafacasari/DiscordMute/releases/latest)

## About
A MelonLoader Mod to enable **Offline Mode** (when Steam is closed) into Desktop Mate. This can be useful if you want to have Desktop Mate on Windows Startup but don't want Steam to open with it.

## What is "Offline Mode"?
Offline Mode means that you can run the DesktopMate .exe file without requiring the Steam Client to be open. If you already have Steam Client openned the patch will **not** be applied.

## How can I make Desktop Mate start with Windows?
1. Open your game directory (right-click it on Steam Library, **Manage** > **Browse Local Files**)
2. Right-click `DesktopMate.exe` and click on "Create Shortcut"
3. (OPTIONAL: Hiding MelonLoader Console) Right-click the Shortcut and click on **Properties**. Now add ` --melonloader.hideconsole` at the end of the shortcut **Target**
4. Press Win + R, type `shell:Startup` and press enter
6. It should open a folder, move your shortcut to this folder and you're done!

## How to open multiple instances
1. First you need to install MelonLoader and this mod, as usual.
2. Copy the entire DesktopMate folder to a new location (both folders should have MelonLoader and this mod)
3. Start DesktopMate.exe with **Steam closed**

## Why it is archived?
Desktop Mate has updated and make pretty much impossible to mod on newer versions, you can still downgrade using Steam Console and use this mod; but new updates will not be available so it is now a read-only repository.

**How to downgrade?**
1. Use **Win + R** and execute this command: `steam://nav/console`
2. It will open Steam Console, just execute the following command to download the latest version compatible with mods:
`download_depot 3301060 3301061 2467897585300615012`
3. The files will be available at: `C:\Program Files (x86)\Steam\steamapps\content\app_3301060\depot_3301061` (this may change depending where you have Steam installed)
4. Install MelonLoader in this folder and you should be ready to use this and many other mods available by the community!

Of course there is other ways of getting the old version, but this is the safest one.
