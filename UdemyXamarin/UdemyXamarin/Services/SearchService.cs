using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyXamarin.Models;

namespace UdemyXamarin.Services
{
    class SearchService
    {
        private List<Search> _searches = new List<Search>
        {
            new Search
            {
                Id = 1,
                Location = "West Holywood, CA, United States",
                CheckIn = new DateTime(2016, 9, 1),
                CheckOut = new DateTime(2016, 11, 1)
            },
            new Search
            {
                Id = 2,
                Location = "Santa Monica, CA, United States",
                CheckIn = new DateTime(2016, 9, 1),
                CheckOut = new DateTime(2016, 11, 1)
            }
        };

        public IEnumerable<Search> GetRecentSearches(string filter = null)
        {
            if (string.IsNullOrWhiteSpace(filter))
            {
                return _searches;
            }
            else
            {
                return _searches.Where(s => s.Location.StartsWith(filter, StringComparison.CurrentCultureIgnoreCase));
            }
        }

        public void DeleteSearch(int searchId)
        {
            _searches.Remove(_searches.Single(s => s.Id == searchId));
        }
    }
}
