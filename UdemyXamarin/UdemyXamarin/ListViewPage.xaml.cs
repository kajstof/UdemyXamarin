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
    public partial class ListViewPage : ContentPage
    {
        private List<ContactGroup> contacts;

        public ListViewPage()
        {
            InitializeComponent();

            contacts = new List<ContactGroup>
            {
                new ContactGroup("K-key", "K")
                {
                    new Contact { Name = "Kajstof", ImageUrl = "http://lorempixel.com/100/100/people/1" },
                    new Contact { Name = "Krzyś", ImageUrl = "http://lorempixel.com/100/100/people/2", Status = "Hey, let's talk!" }
                },
                new ContactGroup("L-key", "L")
                {
                    new Contact { Name = "Lemming", ImageUrl = "http://lorempixel.com/100/100/people/3", Status = "Hey, let's talk again!" }
                }
            };
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
            //contacts[contacts.FindIndex(c => c.ShortTitle.ToUpper()[0] == contact.Name.ToUpper()[0])].Remove(contact);
        }
    }
}