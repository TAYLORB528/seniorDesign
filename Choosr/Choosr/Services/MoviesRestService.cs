using System;
using System.Net.Http;
using System.Collections.ObjectModel;
using Choosr.Models;
using Choosr.ViewModels;
using System.Threading.Tasks;

namespace Choosr.Services
{
    public class MoviesRestService
    {
        HttpClient client = new HttpClient();

        public MoviesRestService()
        {

        }

        public async Task<String> GetMovies()
        {
            var movies = await client.GetStringAsync("https://api.themoviedb.org/3/discover/movie?with_genres=28&page=1&include_adult=false&sort_by=popularity.desc&language=en-US&api_key=76c1fde2b77e48b2c68d34fe3dff81e2");
            return movies;
        }
    }
}
