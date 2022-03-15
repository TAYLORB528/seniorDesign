using System;

using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Choosr.Views
{
    public partial class ModeSelection : ContentPage
    {
        public bool isAuthenticated = true;
        public ModeSelection()
        {
            InitializeComponent();

            MessagingCenter.Subscribe<App>(this, "Hi", (sender) =>
            {
                isAuthenticated = true;
            });

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

        private async void EnterCodeButton(System.Object sender, System.EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(EnterGroup)}");
        }
    }
}
