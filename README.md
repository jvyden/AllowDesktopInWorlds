# AllowDesktopInWorlds

A [ResoniteModLoader](https://github.com/resonite-modding-group/ResoniteModLoader) mod for [Resonite](https://resonite.com/) that allows you to use the `DesktopTextureProvider` in non-userspace environments.

The intended use-case of this is for those who use RTMP screens to screenshare ingame, but want to view their screen without the added latency or a VR overlay.

I'm not entirely sure of the security implications of this, so only use this if you trust the people around you.

This patch also isn't robust so it might break; I just made this to work.
Please open an issue if you also want to use this mod, I can clean things up and add it to the official mod database.

## Screenshots
![Screenshot of my display working ingame](https://raw.githubusercontent.com/jvyden/AllowDesktopInWorlds/refs/heads/main/screenshot.jpg)

## Installation
1. Install [ResoniteModLoader](https://github.com/resonite-modding-group/ResoniteModLoader).
1. Place [AllowDesktopInWorlds.dll](https://github.com/YourGithubUsername/YourModRepoName/releases/latest/download/ExampleModName.dll) into your `rml_mods` folder. This folder should be at `C:\Program Files (x86)\Steam\steamapps\common\Resonite\rml_mods` for a default install. You can create it if it's missing, or if you launch the game once with ResoniteModLoader installed it will create this folder for you.
1. Start the game. If you want to verify that the mod is working you can check your Resonite logs.

## TODO/Wishlist

- [ ] Figure out if this can be used maliciously
- [ ] If so, add world/host whitelist
- [ ] Add setting to toggle the mod instead? (off by default every launch?)