using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UdemyXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuotesPage : ContentPage
    {
        int counter = 0;
        string[] quotes = { "Wlazł kotek", "Na płotek", "I mruga", "Ładna to Piosenka", "Niedługa", "Niedługa, nie krótka", "Lecz w sam raz", "Zaśpiewaj koteczku", "Jeszcze raz" };

        public QuotesPage()
        {
            InitializeComponent();
            NextSentence();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            NextSentence();
        }

        private void NextSentence()
        {
            currentQuote.Text = quotes[counter++];
            if (counter > quotes.Length - 1)
                counter = 0;
        }
    }
}