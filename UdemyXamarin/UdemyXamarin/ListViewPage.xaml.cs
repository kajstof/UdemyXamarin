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
        public ListViewPage()
        {
            InitializeComponent();

            var names = new List<ContactGroup>
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
            listView.ItemsSource = names;
        }
    }
}