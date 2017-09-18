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
    public partial class AbsolutePage : ContentPage
    {
        public AbsolutePage()
        {
            InitializeComponent();
            var layout = new AbsoluteLayout();
            Content = layout;
            var aquaBox = new BoxView { Color = Color.Aqua };
            layout.Children.Add(aquaBox, new Rectangle(0, 0, 1, 1), AbsoluteLayoutFlags.All);
            AbsoluteLayout.SetLayoutBounds(aquaBox, new Rectangle(0, 0, 1, 1));
            //AbsoluteLayout.SetLayoutFlags(aquaBox, AbsoluteLayoutFlags.HeightProportional);
        }
    }
}