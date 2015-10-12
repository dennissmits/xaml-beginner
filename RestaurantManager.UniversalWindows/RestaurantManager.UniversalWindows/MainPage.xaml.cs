﻿using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace RestaurantManager.UniversalWindows
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void ButtonExpedite_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof (ExpeditePage), null);
        }

        private void SubmitOrderButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof (OrderPage), null);
        }
    }
}
