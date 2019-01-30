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
    public partial class TabbedExamplePage : TabbedPage
    {
        public TabbedExamplePage()
        {
            InitializeComponent();
            //this.Children.Add(new ContentPage());
            //this.Children.Add(new NavigationPage(new ContentPage()));
            //this.Children.Add(new ContentPage());
        }
    }
}