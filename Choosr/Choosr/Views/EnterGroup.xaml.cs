using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Choosr.Services;

namespace Choosr.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EnterGroup : ContentPage
    {
        GamePlayRestService RestService = new GamePlayRestService();
        public EnterGroup()
        {
            InitializeComponent();
            fileImage.Source = (Device.RuntimePlatform == Device.Android) ? ImageSource.FromFile("ChoosrLogo.png") : ImageSource.FromFile("ChoosrLogo.png");
            groupEntry.Keyboard = Keyboard.Create(KeyboardFlags.CapitalizeNone);
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            string x = groupEntry.Text;
            BsonDocument tempText = await RestService.GetJoinCode(x);
            if ((string.IsNullOrEmpty(x)) || string.IsNullOrWhiteSpace(x))
            {
                await DisplayAlert("", "Join Code field is empty. Please enter your Join Code", "Try Again");
                return;
            }
            else if (tempText != null)
            {
                await Shell.Current.GoToAsync($"//{nameof(CategorySelection)}");
            }
            else
            {
                await DisplayAlert("", "Incorrect Join Code", "Try Again");
            }
        }
    }
}