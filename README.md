> [!NOTE]  
> This is a fork of [SonicAudioTools](https://github.com/blueskythlikesclouds/SonicAudioTools) based on my [fork](https://github.com/alexankitty/SonicAudioTools) which strips out all instances of WinForms for better cross platform support. 
>
> If you need to run the main GUI utilities under Linux or something else, please use WINE. This project should be used by other projects who only need the CLI interface.
>
> AcbInjector and CsbBuilder are GUI driven projects, those are out of scope for this repo and not included.

# Sonic Audio Tools

A set of tools to modify CRIWARE file formats.

## Disclaimer

This project is no longer maintained. I have not done any significant development for several years, and do not have any plans to do so. However, if you wish to contribute to the project, I'm open to accepting pull requests.

## Releases

You can get the latest development builds on the [AppVeyor page.](https://ci.appveyor.com/project/blueskythlikesclouds/sonicaudiotools/build/artifacts)  
Stable builds are published on the [Releases page.](https://github.com/blueskythlikesclouds/SonicAudioTools/releases)

## Building

If you still wish to build the solution yourself, do as follows:

1. Clone from [GitHub](https://github.com/blueskythlikesclouds/SonicAudioTools.git) `git clone https://github.com/blueskythlikesclouds/SonicAudioTools.git`
2. Open the solution in Visual Studio. (Visual Studio 2017 or later is required.)
3. Install the missing NuGet packages.
4. Build the solution.

## Projects

If you wish to see more detailed information about the projects, visit the [wiki](https://github.com/blueskythlikesclouds/SonicAudioTools/wiki) page.

### [Sonic Audio Library](https://github.com/alexankitty/SonicAudioTools/tree/master/Source/SonicAudioLib)

This is the main library of the solution.  Contains classes for IO and file formats.

### [ACB Editor](https://github.com/alexankitty/SonicAudioTools/tree/master/Source/AcbEditor)

This tool allows you to edit the audio content of an ACB file.  

### [ACB Finder](https://github.com/alexankitty/SonicAudioTools/tree/master/Source/AcbFinder)

This tool allows you to find AWB files and link them back to the ACB, required in extracting certain ACB files.
Useful for games where the AWB files may be renamed or hidden (like Phantasy Star Online 2)

### [CSB Editor](https://github.com/alexankitty/SonicAudioTools/tree/master/Source/CsbEditor)

This tool allows you to edit the audio content of a CSB file.  
It works like ACB Editor, and it is a lot simpler to use than CSB Builder.

## License

See [LICENSE.md](https://github.com/alexankitty/SonicAudioTools/blob/master/LICENSE.md) for details.
