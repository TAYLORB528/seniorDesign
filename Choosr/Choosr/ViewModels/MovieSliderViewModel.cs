using MLToolkit.Forms.SwipeCardView.Core;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using Choosr.Models;
using Choosr.Services;
using System.Collections.Generic;
using Choosr.ViewModels;
using System.Text;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace Choosr.ViewModels
{
    public class MovieSliderViewModel
    {
        private ObservableCollection<Movie> _movies = new ObservableCollection<Movie>();
        MoviesRestService movieClient = new MoviesRestService();

        public MovieSliderViewModel()
        {
            GetMovies();

        }

        public object Convert(string value)
        {
            String MovieDbImageBaseUrl = "https://image.tmdb.org/t/p/w500";
            var uri = new Uri($"{MovieDbImageBaseUrl}{value}");
            var image = ImageSource.FromUri(uri);

            return image;
        }

        public async void GetMovies()
        {
            var movies = await movieClient.GetMovies();
            var moviesArray = movies;
            JObject movieObject = JObject.Parse(movies);
            ObservableCollection<Movie> _movies = new ObservableCollection<Movie>();
            foreach (var movie in movieObject.SelectToken("results"))
            {
                object movieImage = Convert((String)movie["backdrop_path"]);
                Movies.Add(new Movie { Title = (String)movie["title"], Overview = (String)movie["overview"], ID = (int)movie["id"], ImagePath = movieImage });
            }

        }

        public ObservableCollection<Movie> Movies
        {
            get => _movies;
            set
            {
                _movies = value;
            }
        }

    }
}
