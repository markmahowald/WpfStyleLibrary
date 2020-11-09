using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Ui.Wpf
{
    public sealed class Theme
    {
        [ThreadStatic]
        private static ResourceDictionary resourceDictionary;

        internal static ResourceDictionary ResourceDictionary
        {
            get
            {
                if (resourceDictionary != null)
                {
                    return resourceDictionary;
                }
                resourceDictionary = new ResourceDictionary();
                LoadThemeType(ThemeType.Light);
                return resourceDictionary;
            }
        }
        public static ThemeType ThemeType { get; set; } = ThemeType.Light;

        public static void LoadThemeType(ThemeType type)
        {
            ThemeType = type;
            switch (type)
            {
                case ThemeType.Light:
                    SetResource(ThemeResourceKey.ContentBackground.ToString(),
                        new SolidColorBrush(ColorFromHex("#FFFFFFFF")));
                    SetResource(ThemeResourceKey.ContentForeground.ToString(),
                        new SolidColorBrush(ColorFromHex("#FF000000")));
                    break;

                case ThemeType.Dark:
                    SetResource(ThemeResourceKey.ContentBackground.ToString(),
                        new SolidColorBrush(ColorFromHex("#FF000000")));
                    SetResource(ThemeResourceKey.ContentForeground.ToString(),
                        new SolidColorBrush(ColorFromHex("#FFFFFFFF")));
                    break;

                default:
                    break;
            }
        }

        public static object GetResource(ThemeResourceKey resourceKey)
        {
            return ResourceDictionary.Contains(resourceKey.ToString()) ?
                ResourceDictionary[resourceKey.ToString()] : null;
        }

        internal static void SetResource(object key, object resource)
        {
            ResourceDictionary[key] = resource;
        }

        internal static Color ColorFromHex(string colorHex)
        {
            return (Color?)ColorConverter.ConvertFromString(colorHex) ?? Colors.Transparent;
        }
    }
}
