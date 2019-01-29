using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using UdemyXamarin.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UdemyXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactBookSQLiteExerciseEditPage : ContentPage
    {
        public event EventHandler<ContactBookRecord> ContactAdded;
        public event EventHandler<ContactBookRecord> ContactUpdated;

        public ContactBookSQLiteExerciseEditPage(ContactBookRecord contact)
        {
            if (contact is null)
            {
                throw new ArgumentNullException(nameof(contact));
            }

            InitializeComponent();

            var editContact = new ContactBookRecord()
            {
                ID = contact.ID,
                FirstName = contact.FirstName,
                LastName = contact.LastName,
                Phone = contact.Phone,
                Email = contact.Email,
                IsBlocked = contact.IsBlocked
            };
            BindingContext = editContact;
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            var contact = BindingContext as ContactBookRecord;

            if (string.IsNullOrWhiteSpace(contact.FullName))
            {
                DisplayAlert("Error", "Please enter the name", "OK");
                return;
            }

            if (contact.ID == 0)
            {
                contact.ID = 1;
                ContactAdded?.Invoke(this, contact);
            }
            else
            {
                ContactUpdated?.Invoke(this, contact);
            }

            await Navigation.PopAsync();
        }
    }
}