using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HelloWorld;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UdemyXamarin
{
    public class Movie
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NetflixRoulette : ContentPage
    {
        private const string Url = "http://www.netflix.com";
        private HttpClient _httpClient = new HttpClient();
        private ObservableCollection<Movie> _movies;

        public NetflixRoulette()
        {
            InitializeComponent();
            
            _movies = new ObservableCollection<Movie>
            {
                new Movie() {Title = "Batman", Year = "1990" , Description = "Aaaaaaaaa a aaa a a a a aaaaaaaaaaaa a aaa a a ", ImageUrl = "http://lorempixel.com/800/600" },
                new Movie() {Title = "Star Wars", Year = "1991" , Description = "Baaaaaaaa b aaa a a a a aaaaaaaaaaaa a aaa a a ", ImageUrl = "http://lorempixel.com/800/600" },
                new Movie() {Title = "Texas Ranger", Year = "1994" , Description = "A police officer ...", ImageUrl = "http://lorempixel.com/800/600" },
                new Movie() {Title = "Delta Force 1", Year = "1987" , Description = "Hijack of plane1", ImageUrl = "http://lorempixel.com/800/600" },
                new Movie() {Title = "Delta Force 2", Year = "1990" , Description = "Hijack of plane2", ImageUrl = "http://lorempixel.com/800/600" },
                new Movie() {Title = "Delta Force 3", Year = "1994" , Description = "Hijack of plane3", ImageUrl = "http://lorempixel.com/800/600" },
            };
        }

        private void SearchBar_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (e.NewTextValue.Length < 5)
                return;
        }

        private IEnumerable<Movie> FindMoviesByActor(string searchText)
        {
            return new List<Movie>
            {
                new Movie() {Title = "Batman", Year = "1990" , Description = "Aaaaaaaaa a aaa a a a a aaaaaaaaaaaa a aaa a a ", ImageUrl = "http://lorempixel.com/800/600" },
                new Movie() {Title = "Star Wars", Year = "1991" , Description = "Baaaaaaaa b aaa a a a a aaaaaaaaaaaa a aaa a a ", ImageUrl = "http://lorempixel.com/800/600" },
                new Movie() {Title = "Texas Ranger", Year = "1994" , Description = "A police officer ...", ImageUrl = "http://lorempixel.com/800/600" },
                new Movie() {Title = "Delta Force 1", Year = "1987" , Description = "Hijack of plane1", ImageUrl = "http://lorempixel.com/800/600" },
                new Movie() {Title = "Delta Force 2", Year = "1990" , Description = "Hijack of plane2", ImageUrl = "http://lorempixel.com/800/600" },
                new Movie() {Title = "Delta Force 3", Year = "1994" , Description = "Hijack of plane3", ImageUrl = "http://lorempixel.com/800/600" },
            };
        }

        private Movie GetMovie(string title)
        {
            return null;
        }

        private void NetflixMoviesList_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}