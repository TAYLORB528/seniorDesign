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
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(MovieSlider)}");
        }
    }
}
