using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace HelloWorld
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }

    public partial class RestfulServicePage : ContentPage
    {
        private const string Url = "https://jsonplaceholder.typicode.com/posts";
        private HttpClient _httpClient = new HttpClient();
        private ObservableCollection<Post> _posts;
        
        public RestfulServicePage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            var content = await _httpClient.GetStringAsync(Url);
            var posts = JsonConvert.DeserializeObject<List<Post>>(content);
            _posts = new ObservableCollection<Post>(posts);
            postsListView.ItemsSource = _posts; 

            base.OnAppearing();
        }

        async void OnAdd(object sender, System.EventArgs e)
        {
            var post = new Post
            {
                Title = $"Title {DateTime.Now.Ticks}"
            };
            _posts.Insert(0, post);

            var content = JsonConvert.SerializeObject(post);
            await _httpClient.PostAsync(Url, new StringContent(content));
        }

        async void OnUpdate(object sender, System.EventArgs e)
        {
            var post = _posts[0];
            post.Title += " Updated";

            var content = JsonConvert.SerializeObject(post);
            await _httpClient.PutAsync(Url + "/" + post.Id, new StringContent(content));

        }

        async void OnDelete(object sender, System.EventArgs e)
        {
            var post = _posts[0];
            await _httpClient.DeleteAsync(Url + "/" + post.Id);
        }
    }
}