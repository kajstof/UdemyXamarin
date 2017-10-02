using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyXamarin.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UdemyXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        private ObservableCollection<ContactGroup> contacts;

        public ListViewPage()
        {
            InitializeComponent();
            contacts = GetContacts();
            listView.ItemsSource = contacts;
        }

        private void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //var contact = e.Item as Contact;
            //DisplayAlert("Tapped", contact.Name, "OK");
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //var contact = e.SelectedItem as Contact;
            //DisplayAlert("Selected", contact.Name, "OK");
            listView.SelectedItem = null;
        }

        private void Call_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;
            DisplayAlert("Call", contact.Name, "OK");
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;
            //contacts.Remove(contact);
            int index = contacts.ToList().FindIndex(c => c.ShortTitle.ToUpper()[0] == contact.Name.ToUpper()[0]);
            int index2 = contacts[index].ToList().FindIndex(c => c == contact);
            //DisplayAlert("Element", $"contacts[{index}][{index2}]", "OK");
            contacts[index].RemoveAt(index2);
            if (contacts[index].Count == 0) { contacts.RemoveAt(index); }
        }

        private void listView_Refreshing(object sender, EventArgs e)
        {
            contacts = GetContacts();
            listView.ItemsSource = contacts;
            listView.EndRefresh();
        }

        private ObservableCollection<ContactGroup> GetContacts(string searchText = null)
        {
            var contacts = new ObservableCollection<ContactGroup>
            {
                new ContactGroup("K-key", "K")
                {
                    new Contact { Name = "Kajstof", ImageUrl = "http://lorempixel.com/100/100/people/1" },
                    new Contact { Name = "Krzyś", ImageUrl = "http://lorempixel.com/100/100/people/2", Status = "Hey, let's talk!" }
                },
                new ContactGroup("L-key", "L")
                {
                    new Contact { Name = "Lemming", ImageUrl = "http://lorempixel.com/100/100/people/3", Status = "Hey, let's talk again!" }
                },
                new ContactGroup("N-key", "N")
                {
                    new Contact { Name = "Natalia", ImageUrl = "http://lorempixel.com/100/100/people/4", Status = "What's my name!?" },
                    new Contact { Name = "Nikita", ImageUrl = "http://lorempixel.com/100/100/people/5", Status = "We are living in yellow submarine." }
                },
                new ContactGroup("P-key", "P")
                {
                    new Contact { Name = "Parabola", ImageUrl = "http://lorempixel.com/100/100/people/6", Status = "Nice coordinates!" },
                    new Contact { Name = "Picasso", ImageUrl = "http://lorempixel.com/100/100/people/7" },
                    new Contact { Name = "President", ImageUrl = "http://lorempixel.com/100/100/people/8", Status = "Republic of Poland!" }
                },
                new ContactGroup("Z-key", "Z")
                {
                    new Contact { Name = "Zorro", ImageUrl = "http://lorempixel.com/100/100/people/9", Status = "Where is Isaura?" },
                    new Contact { Name = "Zoltan", ImageUrl = "http://lorempixel.com/100/100/people/10", Status = "Hey, what are you looking for?" }
                }

            };

            if (string.IsNullOrWhiteSpace(searchText))
            {
                return contacts;
            }
            else
            {
                //var filteredContacts = contacts.Select(c => c..Where(c => c.Where(c2 => c2.ToString().StartsWith(searchText)))
                //var filteredContacts = contacts.Where(c => c.Count > 0);
                return (ObservableCollection<ContactGroup>)filteredContacts;
            }
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}