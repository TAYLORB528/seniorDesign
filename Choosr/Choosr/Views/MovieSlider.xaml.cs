using System;
using System.Collections.Generic;
using Choosr.ViewModels;
using Xamarin.Forms;
using Choosr.Services;
using System.Collections.ObjectModel;
using System.Text;
using Choosr.Models;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace Choosr.Views
{
    public partial class MovieSlider : ContentPage
    {

        public MovieSlider()
        {
            InitializeComponent();

            BindingContext = new MovieSliderViewModel();
            fileImage.Source = (Device.RuntimePlatform == Device.Android) ? ImageSource.FromFile("ChoosrLogo.png") : ImageSource.FromFile("ChoosrLogo.png");

        }

        void OnSwiped(object sender, SwipedEventArgs e)
        {
            switch (e.Direction)
            {
                case SwipeDirection.Left:
                    Console.WriteLine("went left");
                    break;
                case SwipeDirection.Right:
                    Console.WriteLine("went right");
                    break;
            }
        }
    }
}
