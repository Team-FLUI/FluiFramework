# FLUI Framework
FLUI Framework (short for Fluent UI Framework) is an effort to bring standardisation to Microsofts Fluent Design by providing easy-to-use styles and controls to developers so they won’t have to reinvent the wheel for styling their apps. 


## How to use
Add the following [NuGet package](https://www.nuget.org/packages/FluiFramework.UWP) to your project and reference it in your App.xaml. flui is a reference in your XAML to FluiFramework.UWP.Core.

    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <flui:FluiFrameworkThemeResources/>
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Application.Resources>


## Supported Windows versions
**Minimal supported Windows 10 version:** 15063 (Version 1703, Creators Update)

**Target supported Windows 10 version:** 18362 (Version 1903)

**Currently supported systems:**

* Windows 10 Desktop ✔
* Windows 10 Team ✔
* Windows 10 Holographic ✔
* Windows 10 Xbox ✔
* Windows 10 Mobile ✔


## Notes
FLUI Framework will automatically check which resources can be applied on the running Windows version. If the running OS version doesn't support a feature (like the CornerRadius on pre-1809 devices) it'll use a compatible version of the stylesheet that doesn't incorporate it and thus won't use rounded corners.


## Support us
**Like this project?** Support it by using it in your UWP projects and to share about it with #FLUI and #FluiFramework on Twitter!
