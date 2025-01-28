# About
A MelonLoader Mod to enable **Offline Mode** (when Steam is closed) into Desktop Mate. This can be useful if you want to have Desktop Mate on Windows Startup but don't want Steam to open with it.

## What is "Offline Mode"?
Offline Mode means that you can run the DesktopMate .exe file without requiring the Steam Client to be open. If you already have Steam Client openned the patch will **not** be applied.

# How can I make Desktop Mate start with Windows?
1. Open your game directory (right-click it on Steam Library, **Manage** > **Browse Local Files**)
2. Right-click `DesktopMate.exe` and click on "Create Shortcut"
3. (OPTIONAL: Hiding MelonLoader Console) Right-click the Shortcut and click on **Properties**. Now add ` --melonloader.hideconsole` at the end of the shortcut **Target**
4. Press Win + R, type `shell:Startup` and press enter
6. It should open a folder, move your shortcut to this folder and you're done!
