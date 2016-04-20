﻿using PetCapsuleGUI.Logic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
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
    public sealed partial class CapsulesPage : Page
    {

        public EventHandler cageClick;

        public CapsulesPage()
        {
            this.InitializeComponent();

            List<Button> btns = new List<Button>();
            int count = 1;
            foreach (Cage c in UserContainer.user.getCages())
            {
                Button b = new Button();
                b.Content = "Capsule " + count;
                b.FontSize = 25;
                b.Height = 50;
                b.Width = 200;
                b.Background = new SolidColorBrush(Color.FromArgb(255, 185, 18, 27));
                b.Foreground = new SolidColorBrush(Color.FromArgb(255, 252, 250, 225));
                // b.Click += cageClick;
                //b.Margin = ;
                btns.Add(b);
                count++;
            }

            CapsulesScroll.ItemsSource = btns;

        }

        
        private void HandlecageClick(object sender, System.EventArgs e)
        {

        }

        private void CapsuleButton1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CagePage));
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(FrontPage));
        }
    }
}
