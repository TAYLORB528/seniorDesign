using System;
using Xamarin.Forms;

namespace Choosr.Views
{
    public partial class CategorySelection : ContentPage
    {
        public CategorySelection()
        {
            InitializeComponent();
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(Home)}");
        }
        private async void OnButtonClicked2(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(Home)}");
        }
        private async void OnButtonClicked3(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(Home)}");
        }
        private async void OnButtonClicked4(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(Home)}");
        }
        private async void OnButtonClicked5(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(Home)}");
        }
    }
}
