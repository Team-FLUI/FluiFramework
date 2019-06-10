using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace FluiFramework.UWP.Core
{
    public sealed class FluiFrameworkThemeResources : ResourceDictionary
    {
        public FluiFrameworkThemeResources()
        {
            // Regular styles
            this.MergedDictionaries.Add(new ResourceDictionary { Source = new Uri("ms-appx:///FluiFramework.UWP.Core/Styles/_Thickness.xaml") });
            this.MergedDictionaries.Add(new ResourceDictionary { Source = new Uri("ms-appx:///FluiFramework.UWP.Core/Styles/_Corners.xaml") });

            // Control styles
            this.MergedDictionaries.Add(new ResourceDictionary { Source = new Uri("ms-appx:///FluiFramework.UWP.Core/Styles/TextBlock.xaml") });
            this.MergedDictionaries.Add(new ResourceDictionary { Source = new Uri("ms-appx:///FluiFramework.UWP.Core/Styles/TextBox.xaml") });
        }
    }
}
