# FLUI Framework
FLUI Framework (short for Fluent UI Framework) is an effort to bring standardisation to Microsofts Fluent Design by providing easy-to-use styles and controls to developers so they won’t have to reinvent the wheel for styling their apps. 


## How to use
Add the following [NuGet package](https://www.nuget.org/packages/FluiFramework.UWP/0.0.22-alpha) to your project and reference it in your App.xaml. flui is a reference in your XAML to FluiFramework.UWP.Core.

    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <flui:FluiFrameworkThemeResources/>
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Application.Resources>


## Supported Windows versions
**Minimal supported Windows 10 version:** 17763 (Version 1809)

**Target supported Windows 10 version:** 18362 (Version 1903)

**Currently supported systems:**

* Windows 10 Desktop ✔
* Windows 10 Team ✔
* Windows 10 Holographic ✔
* Windows 10 Xbox ✔

* Windows 10 Mobile ❌ - (Mobile is stuck on RS2, and won't get any new features that are being used by these tools)


## Support us
**Like this project?** Support it by using it in your UWP projects and to share about it with #FLUI and #FluiFramework on Twitter!
