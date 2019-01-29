using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using HelloWorld;
using SQLite;
using UdemyXamarin.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UdemyXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactBookSQLiteExerciseMainPage : ContentPage
    {
        private readonly SQLiteAsyncConnection _connection;

        private ObservableCollection<ContactBookRecord> _contacts { get; set; }

        public ContactBookSQLiteExerciseMainPage()
        {
            InitializeComponent();
            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
        }

        //private IEnumerable<ContactBookRecord> GetContacts()
        //{
        //    return new List<ContactBookRecord>
        //    {
        //        new ContactBookRecord { ID = 1, FirstName = "John", LastName = "Smith", Email = "abc@abc.abc", Phone = "+48 1234567890", IsBlocked = true },
        //        new ContactBookRecord { ID = 2, FirstName = "Krzyś", LastName = "Miś", Email = "def@def.def", Phone = "+48 9876543210", IsBlocked = false },
        //        new ContactBookRecord { ID = 3, FirstName = "Milena", LastName = "Córusia", Email = "def@def.def", Phone = "+48 9876543210", IsBlocked = false }
        //    };
        //}

        protected override async void OnAppearing()
        {
            await _connection.CreateTableAsync<ContactBookRecord>();

            //await _connection.InsertAllAsync(GetContacts());

            var contacts = await _connection.Table<ContactBookRecord>().ToListAsync();
            _contacts = new ObservableCollection<ContactBookRecord>(contacts);
            ContactBookListView.ItemsSource = _contacts;

            base.OnAppearing();
        }

        private async void MenuItemDelete_OnClicked(object sender, EventArgs e)
        {
            ContactBookRecord contact = ((MenuItem)sender).CommandParameter as ContactBookRecord;
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
            ((ListView)sender).SelectedItem = null;

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
            page.ContactAdded += async (source, contact) =>
            {
                _contacts.Add(contact);
                await _connection.InsertAsync(contact);
            };

            await Navigation.PushAsync(page);
        }
        private async void OnAdd(object sender, System.EventArgs e)
        {
            var contact = new ContactBookRecord();
            await _connection.InsertAsync(contact);
            _contacts.Add(contact);
        }

        private async void OnUpdate(object sender, System.EventArgs e)
        {
            //var recipe = _recipes[0];
            //recipe.Name += " Updated";
            //await _connection.UpdateAsync(recipe);
        }

        private async void OnDelete(object sender, System.EventArgs e)
        {
            //var recipe = _recipes[0];
            //await _connection.DeleteAsync(recipe);
            //_recipes.Remove(recipe);
        }
    }
}
