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
using MLToolkit.Forms.SwipeCardView.Core;

namespace Choosr.Views
{
    public partial class MovieSlider : ContentPage
    {

        public MovieSlider()
        {
            InitializeComponent();

            BindingContext = new MovieSliderViewModel();
            SwipeCardView.Dragging += OnDragging;
            fileImage.Source = (Device.RuntimePlatform == Device.Android) ? ImageSource.FromFile("ChoosrLogo.png") : ImageSource.FromFile("ChoosrLogo.png");

        }

        void OnDragging(object sender, DraggingCardEventArgs e)
        {

            var threshold = (BindingContext as MovieSliderViewModel).Threshold;
            if (e.Direction == SwipeCardDirection.Left)
            {
                Console.WriteLine("no");
            }
            else if (e.Direction == SwipeCardDirection.Right)
            {
                for (int i = 0; i < SwipeCardView.ItemsSource.Count; i++)
                {
                    var currentMovie = (Movie)SwipeCardView.ItemsSource[i];
                    var selectedMovie = (Movie)SwipeCardView.TopItem;
                    if (currentMovie.Title == selectedMovie.Title)
                    {
                        Console.WriteLine(selectedMovie);
                    }
                }
            }
        }
    }
}
