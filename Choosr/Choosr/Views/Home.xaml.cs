using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Choosr.Views
{
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();

            fileImage.Source = (Device.RuntimePlatform == Device.Android) ? ImageSource.FromFile("ChoosrLogo.png") : ImageSource.FromFile("ChoosrLogo.png");
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(ModeSelection)}");
        }
    }
}
