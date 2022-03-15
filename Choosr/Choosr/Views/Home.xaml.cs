using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Essentials;

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
            DependencyService.Get<ChoosrInterface>().initiateAuth0();

            await Shell.Current.GoToAsync($"//{nameof(ModeSelection)}");


        }
    }
}
