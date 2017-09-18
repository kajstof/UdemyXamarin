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
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();
            //image.Source = ImageSource.FromResource("UdemyXamarin.Images.background.jpg");
            //btn.Image = (FileImageSource)ImageSource.FromFile(Device.OnPlatform(
            //    iOS: "clock.png",
            //    Android: "clock.png",
            //    WinPhone: "Images/clock.png"));
            //switch (Device.RuntimePlatform)
            //{
            //    case Device.Android:
            //    case Device.iOS:
            //        btn.Image = (FileImageSource)ImageSource.FromFile("clock.png");
            //        break;
            //    case Device.WinPhone:
            //        btn.Image = (FileImageSource)ImageSource.FromFile("Images/clock.png");
            //        break;
            //}
        }
    }
}