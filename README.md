<span style="text-align: center; display: inline-block;">
# VEGAS Pro Rich Presence for Discord
</span>

![GitHub All Releases](https://img.shields.io/github/downloads/GlitchyPSIX/VEGASRPC/total?color=355fff&label=total%20downloads&style=flat-square)

## Overview

This is an extension for VEGAS Pro from MAGIX VEGAS 14 up to VEGAS 21 (downloadable from MAGIX's website) that enables support for Discord's Rich Presence features.

![image](https://github.com/user-attachments/assets/4680b057-18e2-4f5b-b50e-b1970889e875)

``Combines Project Filename and Track Info``

## Features

 * Display how many tracks of both Audio and Video you're currently editing.
   * Display how many events (audio/video/adjustment) are in your Timeline
   * Display your project's name

 * Displays whether you're rendering, and how much time has passed since you started, whether you cancelled, failed, or finished successfully.
   * Displays how much time you've spent since the project was opened

 * Displays when you're just being lazy (300 seconds of inactivity, configurable)

 * Displays a logo related to your VEGAS version as well as its specific version on hover.

## Roadmap

 - [x] Basic functionality stated above
 - [x] Able to turn on and off the Rich Presence
 - [ ] Change the old discord-rpc.dll with the new Game SDK library
 - [ ] Small key icons for when you're recording, etc...
 - [ ] Compatibility with Sony Vegas (Vegas Pro 12 and lower)

## Requirements

 * MAGIX (not Sony) VEGAS Pro 14 and above (64-bit)
   * This does **NOT** work in Movie Studio!
 * .NET Framework 4.8

## Install Instructions

Grab the latest `"VEGASRPC.zip"` from the [Releases tab](https://github.com/GlitchyPSIX/VEGASRPC/releases/latest) and extract its contents in **My Documents/Vegas Application Extensions** or **C:/ProgramData/Vegas Pro/Application Extensions** (Only one of these!).

The folder(s) may or may not already exist. If they don't, create the folder. The easiest one to set up is the one in your Documents folder.

## Building

To build this extension, you need:
 * MAGIX VEGAS Pro 14 or later,
 * .NET Framework 4.8

As of the recent developments that have come about with .NET, it is possible to get this project working in Visual Studio Code

In order to do so, download the .NET 4.8 [Developer Pack](https://dotnet.microsoft.com/en-us/download/dotnet-framework/thank-you/net48-developer-pack-offline-installer) to use the .NET SDK within Visual Studio Code

From there, it is just a case of running ``dotnet build`` within the project directory


## License

MIT. See LICENSE for more details.
