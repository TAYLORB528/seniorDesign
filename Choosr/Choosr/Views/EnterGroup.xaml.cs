using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Choosr.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EnterGroup : ContentPage
    {
        public EnterGroup()
        {
            InitializeComponent();
            fileImage.Source = (Device.RuntimePlatform == Device.Android) ? ImageSource.FromFile("ChoosrLogo.png") : ImageSource.FromFile("ChoosrLogo.png");
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(Home)}");
        }
    }
}