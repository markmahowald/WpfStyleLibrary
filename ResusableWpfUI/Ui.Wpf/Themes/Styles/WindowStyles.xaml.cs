﻿using System.Windows;

namespace Ui.Wpf
{
    public partial class WindowStyles : ResourceDictionary
    {
        public WindowStyles()
        {
            InitializeComponent();
        }

        private void OnCloseClick(object sender, RoutedEventArgs e)
        {
            var window = (Window)((FrameworkElement)sender).TemplatedParent;
            window.Close();
        }

        private void OnMaximizeRestoreClick(object sender, RoutedEventArgs e)
        {
            var window = (Window)((FrameworkElement)sender).TemplatedParent;
            window.Close();
            if (window.WindowState == WindowState.Normal)
            {
                window.WindowState = WindowState.Maximized;
            }
            else
            {
                window.WindowState = WindowState.Normal;
            }
        }
        private void OnMinimizeClick(object sender, RoutedEventArgs e)
        {
            var window = (Window)((FrameworkElement)sender).TemplatedParent;
            window.WindowState = WindowState.Minimized;
        }
        private void OnThemeClick(object sender, RoutedEventArgs e)
        {
            if(Theme.ThemeType == ThemeType.Light)
            {
                Theme.ThemeType = ThemeType.Dark;
            }
            else
            {
                Theme.ThemeType = ThemeType.Light;
            }
            Theme.LoadThemeType(Theme.ThemeType);

        }

    }
}
