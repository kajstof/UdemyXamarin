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
	public partial class GridExercise1Page : ContentPage
	{
		public GridExercise1Page ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "Dial")
            {
                numberLabel.Text = string.Empty;
            }
            else
            {
                numberLabel.Text += ((Button)sender).Text;
            }
        }
    }
}