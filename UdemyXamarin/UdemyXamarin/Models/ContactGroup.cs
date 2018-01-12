using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyXamarin.Models
{
    //class ContactGroup : List<Contact>
    class ContactGroup : ObservableCollection<Contact>
    {
        public string Title { get; set; }
        public string ShortTitle { get; set; }

        public ContactGroup(string title, string shortTitle)
        {
            Title = title;
            ShortTitle = shortTitle;
        }
    }
}
