﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWP_Visual_Asset_Generator.ViewModels;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace UWP_Visual_Asset_Generator.UserControls
{
    public sealed partial class SetBackgroundColourUserControl : UserControl
    {
        public MainViewModel mainViewModel => App.mainViewModel;

        public SetBackgroundColourUserControl()
        {
            this.InitializeComponent();
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            mainViewModel.AssetTypes.ApplyLogo();
            mainViewModel.ShowBackgroundColorSelector = false;
        }
    }
}
