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
    public partial class FormsPage : ContentPage
    {
        public FormsPage()
        {
            InitializeComponent();
        }

        private void Switch_OnToggled(object sender, ToggledEventArgs e)
        {
            label.IsVisible = e.Value;
        }

        private void Slider_OnValueChanged(object sender, ValueChangedEventArgs e)
        {
            var x = e.OldValue;
            var y = e.NewValue;
        }

        private void Entry_OnCompleted(object sender, EventArgs e)
        {
            labelEntry.Text = "Completed";
        }

        private void Entry_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            labelEntry.Text = e.NewTextValue;
        }
    }
}
