# System.Linq.Dynamic

## Build & Test

| Configuration | Status |
|---|---|
| netfx35 | [![Build status](https://dev.azure.com/lib-joe/ak-dynamic-linq/_apis/build/status/NetFx35)](https://lib-joe.visualstudio.com/ak-dynamic-linq/_build/latest?definitionId=4) |
| netfx40 | [![Build status](https://dev.azure.com/lib-joe/ak-dynamic-linq/_apis/build/status/NetFx40)](https://lib-joe.visualstudio.com/ak-dynamic-linq/_build/latest?definitionId=5) |
| netcoreapp2.0 | [![Build status](https://dev.azure.com/lib-joe/ak-dynamic-linq/_apis/build/status/NetCore)](https://lib-joe.visualstudio.com/ak-dynamic-linq/_build/latest?definitionId=7) |
| Silverlight 5 | [![Build status](https://dev.azure.com/lib-joe/ak-dynamic-linq/_apis/build/status/SL)](https://lib-joe.visualstudio.com/ak-dynamic-linq/_build/latest?definitionId=6) |

## Package

| Package | Version |
|---|---|
| NuGet | [![Build status](https://img.shields.io/badge/nuget-1.1.33.0-blue.svg)](https://www.nuget.org/packages/AK.System.Linq.Dynamic/1.1.33) |

## Version History

You can find project release notes on [wiki](https://github.com/meatGUY/System.Linq.Dynamic/wiki/Version-History).

# About
As far as I know the history is somewhat like this.

This project takes his beginning as .NET 3.5 library created by Microsoft for some reason - if I am not mistaken there should be some articles in the MSDN Magazine at least about a parser engine that is used here.

Then it was ported to .NET 4.0 by [@kahanu](https://github.com/kahanu) and shared on the GitHub for public use (MSPL license).

Then [@NArnott](https://github.com/NArnott) forked from @kahanu repository (by this time it was not supported for a while) and did a great job - he introduced unit-tests, web documentation and lots of other stuff (for some period of time I was contributing to his fork). 

Then some time ago [@NArnott](https://github.com/NArnott) dismissed the NuGet package and deleted web documentation from hosted Azure instance, so I took ownership of the library and uploaded a new [package][1] and created a host for [documentation][2].

[1]: https://www.nuget.org/packages/AK.System.Linq.Dynamic/ "NuGet - Dynamic Linq Library"
[2]: http://ak-dynamic-linq.azurewebsites.net

# Credits
I would like to thank everyone who put effort in this project. 

# What's next?
I use this library on several production project that is why it gets updated with new features but most of the time it is not. The project itself is alive and I encourage you to report bugs and propose feature requests (if I would have time, I will do both).

# P.S
Hope I didn't miss anything +)
