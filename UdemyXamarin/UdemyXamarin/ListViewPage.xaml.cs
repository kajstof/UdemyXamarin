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

            var names = new List<Contact>
            {
                new Contact {Name="Kajstof",ImageUrl="http://lorempixel.com/100/100/people/1" },
                new Contact {Name="Krzyś", ImageUrl="http://lorempixel.com/100/100/people/2", Status="Hey, let's talk!"}
            };
            listView.ItemsSource = names;
        }
    }
}