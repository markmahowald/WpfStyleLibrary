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
                    SetResource(ThemeResourceKey.ContentBackground.ToString(), new SolidColorBrush(ColorFromHex("#FFFFFFFF")));
                    SetResource(ThemeResourceKey.ContentForeground.ToString(), new SolidColorBrush(ColorFromHex("#FF3F3F3F")));
                    SetResource(ThemeResourceKey.ControlForeground.ToString(), new SolidColorBrush(ColorFromHex("#FF3F3F3F")));
                    SetResource(ThemeResourceKey.ControlBorder.ToString(), new SolidColorBrush(ColorFromHex("#FF8192A1")));
                    SetResource(ThemeResourceKey.ControlBackground.ToString(), new SolidColorBrush(ColorFromHex("#FFDBE0E4")));
                    SetResource(ThemeResourceKey.ControlContentBackground.ToString(), new SolidColorBrush(ColorFromHex("#FFFFFFFF")));
                    SetResource(ThemeResourceKey.ControlDefaultBorder.ToString(), new SolidColorBrush(ColorFromHex("#FFC12B68")));
                    SetResource(ThemeResourceKey.ControlHighlightBackground.ToString(), new SolidColorBrush(ColorFromHex("#77833AB4")));
                    SetResource(ThemeResourceKey.ControlMouseOverBackground.ToString(), new SolidColorBrush(ColorFromHex("#FFEDEFF2")));
                    SetResource(ThemeResourceKey.ControlMouseOverBorder.ToString(), new SolidColorBrush(ColorFromHex("#FFA53289")));
                    SetResource(ThemeResourceKey.ControlPressedBackground.ToString(), new SolidColorBrush(ColorFromHex("#FFBFC2C4")));
                    SetResource(ThemeResourceKey.ControlPressedBorder.ToString(), new SolidColorBrush(ColorFromHex("#FF3CC0FF")));
                    SetResource(ThemeResourceKey.ControlDisabledOpacity.ToString(), 0.4);
                    SetResource(ThemeResourceKey.ControlFocusBorder.ToString(), new SolidColorBrush(ColorFromHex("#FF833AB4")));
                    SetResource(ThemeResourceKey.GlyphForeground.ToString(), new SolidColorBrush(ColorFromHex("#FF646769")));
                    SetResource(ThemeResourceKey.GroupBoxHeaderBorder.ToString(), new SolidColorBrush(ColorFromHex("#FFA53289")));
                    SetResource(ThemeResourceKey.GroupBoxHeaderForeground.ToString(), new SolidColorBrush(ColorFromHex("#FFA53289")));
                    SetResource(ThemeResourceKey.ListMouseOverBackground.ToString(), new SolidColorBrush(ColorFromHex("#22833AB4")));
                    SetResource(ThemeResourceKey.ListMouseOverBorder.ToString(), new SolidColorBrush(ColorFromHex("#FFA53289")));
                    SetResource(ThemeResourceKey.ListSelectedBackground.ToString(), new SolidColorBrush(ColorFromHex("#FF833AB4")));
                    SetResource(ThemeResourceKey.ListSelectedBorder.ToString(), new SolidColorBrush(ColorFromHex("#FFA53289")));
                    SetResource(ThemeResourceKey.ListSelectedForeground.ToString(), new SolidColorBrush(ColorFromHex("#FFFFFFFF")));
                    SetResource(ThemeResourceKey.WindowBorder.ToString(), new SolidColorBrush(ColorFromHex("#FF616D7B")));
                    SetResource(ThemeResourceKey.WindowActiveBorder.ToString(), new SolidColorBrush(ColorFromHex("#FF833AB4")));
                    SetResource(ThemeResourceKey.WindowControlMouseOverBackground.ToString(), new SolidColorBrush(ColorFromHex("#FF000000")));
                    //SetResource(ThemeResourceKey.WindowHeaderBackground.ToString, new GradientBrush()
                    //SetResource(ThemeResourceKey.WindowHeaderBackground.ToString(), new SolidColorBrush(ColorFromHex("#FF833AB4 #FFFD1D1D")));
                    SetResource(ThemeResourceKey.WindowHeaderForeground.ToString(), new SolidColorBrush(ColorFromHex("#FFFFFFFF")));


                    break;

                case ThemeType.Dark:
                    SetResource(ThemeResourceKey.ContentBackground.ToString(), new SolidColorBrush(ColorFromHex("#FF222529")));
                    SetResource(ThemeResourceKey.ContentForeground.ToString(), new SolidColorBrush(ColorFromHex("#FFF4F6F9")));
                    SetResource(ThemeResourceKey.ControlForeground.ToString(), new SolidColorBrush(ColorFromHex("#FFF4F6F9")));
                    SetResource(ThemeResourceKey.ControlBorder.ToString(), new SolidColorBrush(ColorFromHex("#FF616D7B")));
                    SetResource(ThemeResourceKey.ControlBackground.ToString(), new SolidColorBrush(ColorFromHex("#FF2D3136")));
                    SetResource(ThemeResourceKey.ControlContentBackground.ToString(), new SolidColorBrush(ColorFromHex("#FF1C1E22")));
                    SetResource(ThemeResourceKey.ControlDefaultBorder.ToString(), new SolidColorBrush(ColorFromHex("#FFC12B68")));
                    SetResource(ThemeResourceKey.ControlHighlightBackground.ToString(), new SolidColorBrush(ColorFromHex("#FF833AB4")));
                    SetResource(ThemeResourceKey.ControlMouseOverBackground.ToString(), new SolidColorBrush(ColorFromHex("#FF4C525E")));
                    SetResource(ThemeResourceKey.ControlMouseOverBorder.ToString(), new SolidColorBrush(ColorFromHex("#FFA53289")));
                    SetResource(ThemeResourceKey.ControlPressedBackground.ToString(), new SolidColorBrush(ColorFromHex("#FF222529")));
                    SetResource(ThemeResourceKey.ControlPressedBorder.ToString(), new SolidColorBrush(ColorFromHex("#FF00ACE0")));
                    SetResource(ThemeResourceKey.ControlDisabledOpacity.ToString(), 0.4);
                    SetResource(ThemeResourceKey.ControlFocusBorder.ToString(), new SolidColorBrush(ColorFromHex("#FF833AB4")));
                    SetResource(ThemeResourceKey.GlyphForeground.ToString(), new SolidColorBrush(ColorFromHex("#FFEBECED")));
                    SetResource(ThemeResourceKey.GroupBoxHeaderBorder.ToString(), new SolidColorBrush(ColorFromHex("#FFBF399E")));
                    SetResource(ThemeResourceKey.GroupBoxHeaderForeground.ToString(), new SolidColorBrush(ColorFromHex("#FFBF399E")));
                    SetResource(ThemeResourceKey.ListMouseOverBackground.ToString(), new SolidColorBrush(ColorFromHex("#22833AB4")));
                    SetResource(ThemeResourceKey.ListMouseOverBorder.ToString(), new SolidColorBrush(ColorFromHex("#FFA53289")));
                    SetResource(ThemeResourceKey.ListSelectedBackground.ToString(), new SolidColorBrush(ColorFromHex("#FF833AB4")));
                    SetResource(ThemeResourceKey.ListSelectedBorder.ToString(), new SolidColorBrush(ColorFromHex("#FFA53289")));
                    SetResource(ThemeResourceKey.ListSelectedForeground.ToString(), new SolidColorBrush(ColorFromHex("#FFFFFFFF")));
                    SetResource(ThemeResourceKey.WindowBorder.ToString(), new SolidColorBrush(ColorFromHex("#FF616D7B")));
                    SetResource(ThemeResourceKey.WindowActiveBorder.ToString(), new SolidColorBrush(ColorFromHex("#FF833AB4")));
                    SetResource(ThemeResourceKey.WindowControlMouseOverBackground.ToString(), new SolidColorBrush(ColorFromHex("#FF000000")));
                    //SetResource(ThemeResourceKey.WindowHeaderBackground.ToString(), new SolidColorBrush(ColorFromHex("##FF833AB4 #FFFD1D1D")));
                    SetResource(ThemeResourceKey.WindowHeaderForeground.ToString(), new SolidColorBrush(ColorFromHex("#FFFFFFFF")));


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
