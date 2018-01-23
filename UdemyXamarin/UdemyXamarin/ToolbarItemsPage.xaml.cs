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
    public partial class ToolbarItemsPage : ContentPage
    {
        public ToolbarItemsPage()
        {
            InitializeComponent();
        }

        private void New_Activated(object sender, System.EventArgs e)
        {
            DisplayAlert("Activated", "ToolbarItem Activated", "OK");
        }
    }
}