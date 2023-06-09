# ClearReadOnlyFlags
Clears read-only flags from binaries folders (including plugins). Useful when pushing binaries perforce and it marks read-only after submitting. 

The purpose is to have a shortcut that when executed will clear read-only flags from all "Binaries" folders from the project and all plugins.

This is an exceedingly simple C# helper application. Check Program.cs to view the entirety of the tiny code-base.

![example](https://github.com/Vaei/DeleteBinaries/blob/files/helper_example.png)

## How to Use

1. Create a shortcut to `ClearReadOnlyFlags\ClearReadOnlyFlags\bin\Release\net6.0\ClearReadOnlyFlags.exe`
2. Place it in your project folder alongside the `.uproject` file
3. Clear the "Start In" field. This is vitally important, it will not work otherwise. This field must be empty.
