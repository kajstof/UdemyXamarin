using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyXamarin.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UdemyXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactsPage : MasterDetailPage
    {
        public ContactsPage()
        {
            InitializeComponent();

            listView.ItemsSource = new List<Contact>
            {
                new Contact { Name = "Anna", ImageUrl = "http://lorempixel.com/100/100", Status = "Haha" },
                new Contact { Name = "Kajstof", ImageUrl = "http://lorempixel.com/100/100" },
                new Contact { Name = "Krzyś", ImageUrl = "http://lorempixel.com/100/100", Status = "Hello, I'm there" },
                new Contact { Name = "Milena", ImageUrl = "http://lorempixel.com/100/100", Status = "My Honey" }
            };
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //if (e.SelectedItem == null) { return; }
            var contact = e.SelectedItem as Contact;
            //await Navigation.PushAsync(new ContactDetailPage(contact));
            //listView.SelectedItem = null;
            Detail = new ContactDetailPage(contact);
            IsPresented = false;
        }
    }
}