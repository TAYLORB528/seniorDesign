using System;
using Xamarin.Forms;

namespace Choosr.Views
{
    public partial class CategorySelection : ContentPage
    {
        public CategorySelection()
        {
            InitializeComponent();
            fileImage.Source = (Device.RuntimePlatform == Device.Android) ? ImageSource.FromFile("ChoosrLogo.png") : ImageSource.FromFile("ChoosrLogo.png");

        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(MovieSlider)}");
        }
        private async void OnButtonClicked2(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(MovieSlider)}");
        }
        private async void OnButtonClicked3(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(MovieSlider)}");
        }
        private async void OnButtonClicked4(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(MovieSlider)}");
        }
        private async void OnButtonClicked5(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(MovieSlider)}");
        }
    }
}
