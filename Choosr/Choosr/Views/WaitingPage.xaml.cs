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
                this.Proceed();
            });
        }

        public void Proceed()
        {
            Shell.Current.GoToAsync($"//{nameof(ModeSelection)}");
        }
    }
}
