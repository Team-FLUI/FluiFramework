# FLUI Framework
FLUI Framework (short for Fluent UI Framework) is an effort to bring standardisation to Microsofts Fluent Design by providing easy-to-use styles and controls to developers so they won’t have to reinvent the wheel for styling their apps. 

This library is meant to fill the gaps of the [WinUI library](https://github.com/Microsoft/microsoft-ui-xaml) by providing styles and margins for classic controls and standard TextBlocks. It also adds styles for icons to be used in tandem with their respective style whereas MDL2 was lacking such a thing. 

## Current styles
![Fonts and Controls FLUI Framework vs MDL2](https://raw.githubusercontent.com/Team-FLUI/FluiFramework/master/.github/Assets/Readme/FontsControls-2019-7-17.png)

## How to use
Add the following [NuGet package](https://www.nuget.org/packages/FluiFramework.UWP) to your project and reference it in your App.xaml. flui is a reference in your XAML to FluiFramework.UWP.Core.

    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <flui:FluiFrameworkThemeResources/>
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Application.Resources>

After you've done this you can use the styles laid out in the Wiki on the controls specified there. For instance, you can give a title TextBlock a Fluent title by applying the *FluentTitleTextStyle* style. For example:

`<TextBlock Text="Title" Style="{ThemeResource FluentTitleTextStyle}" />`

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

Please note that this library still is in full development. Styles (aside from the TextBlock-styles) can be updates with a (slightly) different look over time to align it more with the Fluent Design specifications from Microsoft or due to compatibility reasons.

This project is not affiliated with Microsoft, but they are free to reach out and/or use the code within the project for addition to their own repositories. :)

## Support us
**Like this project?** Support it by using it in your UWP projects and to share about it with #FLUI and #FluiFramework on Twitter!
