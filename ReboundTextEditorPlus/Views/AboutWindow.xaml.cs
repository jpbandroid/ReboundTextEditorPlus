﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Windows.Storage;
using Windows.UI.Notifications;
using WinUIEx;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ReboundTextEditorPlus.Views
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AboutWindow : Window
    {
        public AboutWindow()
        {
            this.InitializeComponent();
            this.SetWindowSize(400, 520);
            this.SetIsResizable(false);
            this.SetIsMaximizable(false);
            this.SetIsMinimizable(false);
            this.AppWindow.SetIcon("Assets/icon.ico");
            this.AppWindow.Title = $"About {App.Current.AppName}";
            version.Text = $"Version {App.Current.AppVersion} - Full release";
        }

        private void HyperlinkButton_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_30(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}