using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace FluiFramework.UWP.Core
{
    public sealed class FluiFrameworkThemeResources : ResourceDictionary
    {
        public FluiFrameworkThemeResources()
        {
            // Check OS version and show enable the correct styles compatible with those versions            
            if (ApiInformation.IsApiContractPresent("Windows.Foundation.UniversalApiContract", 7))  // Minimal 1809
            {
                this.MergedDictionaries.Add(new ResourceDictionary { Source = new Uri("ms-appx:///FluiFramework.UWP.Core/Styles/_Corners1809.xaml") });
                this.MergedDictionaries.Add(new ResourceDictionary { Source = new Uri("ms-appx:///FluiFramework.UWP.Core/Styles/ComboBox1809.xaml") });
                this.MergedDictionaries.Add(new ResourceDictionary { Source = new Uri("ms-appx:///FluiFramework.UWP.Core/Styles/TextBox1809.xaml") });
            }
            else // Pre-1809
            {
                this.MergedDictionaries.Add(new ResourceDictionary { Source = new Uri("ms-appx:///FluiFramework.UWP.Core/Styles/ComboBox.xaml") });
                this.MergedDictionaries.Add(new ResourceDictionary { Source = new Uri("ms-appx:///FluiFramework.UWP.Core/Styles/TextBox.xaml") });
            }

            // Compatible between all versions:
            // Regular Styles
            this.MergedDictionaries.Add(new ResourceDictionary { Source = new Uri("ms-appx:///FluiFramework.UWP.Core/Styles/_Thickness.xaml") });

            // Control Styles
            this.MergedDictionaries.Add(new ResourceDictionary { Source = new Uri("ms-appx:///FluiFramework.UWP.Core/Styles/TextBlock.xaml") });
        }
    }
}
