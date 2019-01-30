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
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new IntroductionPage());
            //await Navigation.PushModalAsync(new IntroductionPage());
            string pageToLoad = (sender as Button)?.Text;
            if (pageToLoad != null)
            {
                var pageName = $"{pageToLoad}Page";
                var type = Type.GetType("UdemyXamarin." + pageName, true);
                if (type != null)
                {
                    var instance = (Page)Activator.CreateInstance(type);
                    await Navigation.PushModalAsync(new NavigationPage(instance));
                }
            }
        }
    }
}