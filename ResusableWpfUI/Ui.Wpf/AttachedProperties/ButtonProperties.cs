using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Ui.Wpf.AttachedProperties
{
    public static class ButtonProperties
    {
        #region CornerRadius (AttachedProperty)
        ///<summary>
        ///Identifies the CornerRadius property 
        ///</summary

        public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.RegisterAttached(
            "CornerRadius", 
            typeof(double), 
            typeof(ButtonProperties), 
            new FrameworkPropertyMetadata(0d));


        ///<summary>
        ///Gets the corner radius
        ///</summary>

        public static double GetCornerRadius(DependencyObject obj)
        {
            return (double)obj.GetValue(CornerRadiusProperty);
        }

        ///<summary>
        ///Sets the corner radius
        ///</summary>
        ///
        public static void SetCornerRadius(DependencyObject obj, double value)
        {
            obj.SetValue(CornerRadiusProperty, value);
        }
        #endregion
    }
}
