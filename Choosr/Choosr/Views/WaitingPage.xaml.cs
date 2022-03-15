using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Choosr.Views
{
    public partial class WaitingPage : ContentPage
    {
        public WaitingPage()
        {
            InitializeComponent();
            fileImage.Source = (Device.RuntimePlatform == Device.Android) ? ImageSource.FromFile("ChoosrLogo.png") : ImageSource.FromFile("ChoosrLogo.png");
            // Proceed();

            MessagingCenter.Subscribe<App>(this, "Hi", (sender) =>
            {
                var goodie = 1 + 1;
                Proceed();
            });
        }

        public async void Proceed()
        {
            await Shell.Current.GoToAsync($"//{nameof(ModeSelection)}");
        }
    }
}
