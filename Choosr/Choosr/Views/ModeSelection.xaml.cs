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
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(CategorySelection)}");
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
