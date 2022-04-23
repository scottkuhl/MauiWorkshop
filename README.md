# .NET MAUI - Workshop

Implementation of the [.NET Maui Workshop](https://github.com/dotnet-presentations/dotnet-maui-workshop)


## Getting Started

1. Install the **latest version** of [Visual Studio](https://visualstudio.microsoft.com/).
1. Setup your workstation to develop with **[Maui](https://docs.microsoft.com/en-us/dotnet/maui/get-started/first-app)**.
1. Install the **[CodeMaid](https://marketplace.visualstudio.com/items?itemName=SteveCadwallader.CodeMaidVS2022)** extension.
1. Install the **[XAML Styler for Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=TeamXavalon.XAMLStyler2022)** extension.
1. Install the **[Code Cleanup on Save](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.CodeCleanupOnSave)** extension.  The clean up profile should have all options applied.  Unfortunately at this time, these options can't be stored in a solution.

### Visual Studio 2022

1. Press **F5** to launch application.


## Clean Code Rules

1. [CodeMaid](http://www.codemaid.net/) - The solution folder contains a basic configuration for it that will automatically apply setting on save.
1. [XAML Styler](https://github.com/Xavalon/XamlStyler) - The solution folder contains a basic configuration for it tailored for Maui.
1. [Roslynator](https://github.com/JosefPihrt/Roslynator) - A extended collection of Rosyln analyzers is included as a NuGet package on all projects.
1. [AsyncFixer](http://www.asyncfixer.com/) - A NuGet package included on all projects that finds and corrects common misuses of async/await.
1. A starting .editorconfig file with minimal rule changes is included.
1. Nullable types are enabled.
1. Code styles are [enforced on build](https://docs.microsoft.com/en-us/dotnet/core/project-sdk/msbuild-props#enforcecodestyleinbuild).
1. [Code Cleanup on Save](https://github.com/madskristensen/CodeCleanupOnSave) - Use this extension in Visual Studio to apply code cleanup rules on every save. 
1. Changes should not be committed with unresolved compiler Errors, Warning or Messages.


## Architecture

The application is written in .NET Maui.


## Reference

These references are presented in a logical order for review from start to finish for gathering a deeper understanding of the code base.
There is an assumption that you are already familiar with C# and ASP.NET Core.

### Books & Video Series

### Articles & Videos

- **[Xamarin.Forms to .NET MAUI. Add Beautiful Font Icons to Maui in minutes.](https://www.youtube.com/watch?v=L4tJW1ss2Hc)**: Quick overview on adding font icons to .NET MAUI project.

### Documentation

- **[.NET MAUI](https://docs.microsoft.com/en-us/dotnet/maui/)**: .NET Multi-platform App UI (.NET MAUI) lets you build native apps using a .NET cross-platform UI toolkit that targets the mobile and desktop form factors on Android, iOS, macOS, Windows, and Tizen.

### Other

- **[Icon Font to #Code](https://andreinitescu.github.io/IconFont2Code/)**: Generate C# code from icon font.


## History

A history of important changes.
To learn how a feature was implemented, examine the matching pull requests and branches.

### Workshop

- [Pull Request #1](https://github.com/scottkuhl/MauiWorkshop/pull/1)
- [Workshop Branch](https://github.com/scottkuhl/MauiWorkshop/tree/workshop)

The completed workshop version includes example code that demonstrates the following:

1. **List** views. (Part 1)
2. **MVVM** using the .NET Community Toolkit. (Part 2)
3. Accessing data from a **REST** based API. (Part 2)
4. An **activity indicator** to show while the application is loading data. (Part 2)
5. Shell based **navigation** between views. (Part 3)
6. **Detail** views. (Part 3)
7. **Rounded corners**. (Part 3)
8. **Platform features**. (Part 4)
9. Geo-location data and displaying **maps**. (Part 4)
10. **iOS Safe Area** layout to avoid the notch. (Part 4)
11. **Pull-to-refresh**. (Part 5)
12. Alternate **collection layouts**.  (Part 5)
13. **Empty collection** views. (Part 5)
14. Light / Dark **Themes**. (Part 6)

### Reset

- [Pull Request #2](https://github.com/scottkuhl/MauiWorkshop/pull/2)
- [Reset Branch](https://github.com/scottkuhl/MauiWorkshop/tree/reset)

Reset the starting project to match the default template more closely in RC1.

### Clean Code

- [Pull Request #3](https://github.com/scottkuhl/MauiWorkshop/pull/3)
- [Clean Code Branch](https://github.com/scottkuhl/MauiWorkshop/tree/clean-code)

This README was updated along with adding some clean code best practices.

1. **CodeMaid** Visual Studio extension.
2. **XAML Styler** Visual Studio extension.
3. **Roslynator** NuGet package.
4. **AsyncFixer** NuGetpackage.
5. **.editorconfig** file.
6. **Nullable** types are enabled.
6. **Code styles** are enforced on build.
7. **Code Cleanup on Save** Visual Studio extension.

### Fluent Design

- [Pull Request #4](https://github.com/scottkuhl/MauiWorkshop/pull/4)
- [Fluent Branch](https://github.com/scottkuhl/MauiWorkshop/tree/fluent)

A basic Microsoft Fluent Design theme has been applied.

1. **Native Fonts** are used. The open sans is still available but commented out.
2. **Fluent System Icons** have been added.
