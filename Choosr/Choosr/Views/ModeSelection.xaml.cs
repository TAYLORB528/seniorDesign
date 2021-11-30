using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Choosr.Views
{
    public partial class ModeSelection : ContentPage
    {
        public ModeSelection()
        {
            InitializeComponent();

            fileImage.Source = (Device.RuntimePlatform == Device.Android) ? ImageSource.FromFile("ChoosrLogo.png") : ImageSource.FromFile("ChoosrLogo.png");
        }

        private async void GroupPlayButton(System.Object sender, System.EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(GroupCode)}");
        }

        private async void SinglePlayButton(System.Object sender, System.EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(CategorySelection)}");
        }
    }
}
