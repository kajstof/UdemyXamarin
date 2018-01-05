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
    public partial class ImageExercise : ContentPage
    {
        private int currentItem = 1;

        public ImageExercise()
        {
            InitializeComponent();
            LoadImage();
        }

        private void PreviousButton_Clicked(object sender, EventArgs e)
        {
            if (currentItem == 1) { currentItem = 10; }
            else { currentItem--; }
            LoadImage();
        }

        private void NextButton_Clicked(object sender, EventArgs e)
        {
            if (currentItem == 10) { currentItem = 1; }
            else { currentItem++; }
            LoadImage();
        }

        private void LoadImage()
        {
            image.Source = new UriImageSource
            {
                Uri = new Uri("http://lorempixel.com/1920/1080/city/" + currentItem),
                CachingEnabled = false
            };
        }
    }
}