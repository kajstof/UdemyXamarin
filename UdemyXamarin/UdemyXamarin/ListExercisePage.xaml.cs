using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyXamarin.Models;
using UdemyXamarin.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UdemyXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListExercisePage : ContentPage
    {
        private SearchService _searchService;
        private List<SearchGroup> _searchGroups;

        public ListExercisePage()
        {
            _searchService = new SearchService();
            InitializeComponent();
            PopulateListView(_searchService.GetRecentSearches());
        }
        private void PopulateListView(IEnumerable<Search> searches)
        {
            _searchGroups = new List<SearchGroup>
            {
                new SearchGroup("Recent Searches", searches)
            };
            listView.ItemsSource = _searchGroups;
        }

        private void listView_Refreshing(object sender, EventArgs e)
        {
            PopulateListView(_searchService.GetRecentSearches(searchBar.Text));
            listView.EndRefresh();
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            PopulateListView(_searchService.GetRecentSearches(e.NewTextValue));
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            var search = (sender as MenuItem).CommandParameter as Search;
            _searchGroups[0].Remove(search);
            _searchService.DeleteSearch(search.Id);
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            DisplayAlert("Selected", (e.SelectedItem as Search).Location, "OK");
        }
    }
}