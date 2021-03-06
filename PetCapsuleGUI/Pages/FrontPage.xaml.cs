﻿using PetCapsuleGUI.Logic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace PetCapsuleGUI.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FrontPage : Page
    {
        public FrontPage()
        {
            this.InitializeComponent();
            WelcomeBlock.Text = "Welcome " + UserContainer.user.Username;
        }

        private void CapsulesButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CapsulesPage));
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void InfoButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MyinfoPage));
        }

        private void WelcomeBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
