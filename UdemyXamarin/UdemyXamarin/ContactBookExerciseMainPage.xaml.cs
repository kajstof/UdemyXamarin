using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using UdemyXamarin.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UdemyXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactBookExerciseMainPage : ContentPage
    {
        private ObservableCollection<ContactBookRecord> _contacts { get; set; }

        public ContactBookExerciseMainPage()
        {
            InitializeComponent();

            _contacts = new ObservableCollection<ContactBookRecord>(GetContacts());
			ContactBookListView.ItemsSource = _contacts;
        }

        private IEnumerable<ContactBookRecord> GetContacts()
        {
            return new List<ContactBookRecord>
            {
                new ContactBookRecord { ID = 1, FirstName = "John", LastName = "Smith", Email = "abc@abc.abc", Phone = "+48 1234567890", IsBlocked = true },
                new ContactBookRecord { ID = 2, FirstName = "Krzyś", LastName = "Miś", Email = "def@def.def", Phone = "+48 9876543210", IsBlocked = false },
                new ContactBookRecord { ID = 3, FirstName = "Milena", LastName = "Córusia", Email = "def@def.def", Phone = "+48 9876543210", IsBlocked = false }
            };
        }

        private async void MenuItemDelete_OnClicked(object sender, EventArgs e)
        {
            ContactBookRecord contact = ((MenuItem) sender).CommandParameter as ContactBookRecord;
            bool deleteRecord = await DisplayAlert("Delete contact?", $"Do you really want to delete {contact.FullName}?",
                "Yes", "No");
            if (deleteRecord)
            {
                _contacts.Remove(contact);
            }
        }

        private async void ContactBookListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var selectedContact = e.SelectedItem as ContactBookRecord;

            //Deselect Item
            ((ListView) sender).SelectedItem = null;

            var page = new ContactBookExerciseEditPage(selectedContact);
            page.ContactUpdated += (source, contact) =>
            {
                selectedContact.ID = contact.ID;
                selectedContact.FirstName = contact.FirstName;
                selectedContact.LastName = contact.LastName;
                selectedContact.Phone = contact.Phone;
                selectedContact.Email = contact.Email;
                selectedContact.IsBlocked = contact.IsBlocked;
            };

            await Navigation.PushAsync(page);
        }

        private async void OnAddContact(object sender, EventArgs e)
        {
            var page = new ContactBookExerciseEditPage(new ContactBookRecord());
            page.ContactAdded += (source, contact) => { _contacts.Add(contact); };
            await Navigation.PushAsync(page);
        }
    }
}
