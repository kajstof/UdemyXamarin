using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UdemyXamarin
{
    public class ContactMethod
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Forms2Page : ContentPage
    {
        private IList<ContactMethod> _contactMethods;

        public Forms2Page()
        {
            InitializeComponent();
            _contactMethods = GetContactMethods();

            foreach (var method in _contactMethods)
            {
                contactMethods.Items.Add(method.Name);
            }
        }

        private void Picker_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var name = contactMethods.Items[contactMethods.SelectedIndex];
            var contactMethod = _contactMethods.Single(x => x.Name == name);
            DisplayAlert("Selection", name, "OK");
        }

        private IList<ContactMethod> GetContactMethods()
        {
            return new List<ContactMethod>
            {
                new ContactMethod { Id = 1, Name = "SMS" },
                new ContactMethod { Id = 2, Name = "Email" },
                new ContactMethod { Id = 3, Name = "Phone" }
            };
        }

        private void DatePicker_OnDateSelected(object sender, DateChangedEventArgs e)
        {
            var x = e.NewDate;
            var y = e.OldDate;
        }

        private void EntryCell_OnCompleted(object sender, EventArgs e)
        {
        }

        private void SwitchCell_OnOnChanged(object sender, ToggledEventArgs e)
        {
        }

        private void Cell_OnTapped(object sender, EventArgs e)
        {
            var page = new ContactMethodsPage();
            page.ContactMethods.ItemSelected += (source, args) =>
            {
                contactMethod.Text = args.SelectedItem.ToString();
                Navigation.PopAsync();
            };
            Navigation.PushAsync(page);
        }
    }
}