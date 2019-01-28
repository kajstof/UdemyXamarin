using System;
using UdemyXamarin;
using Xamarin.Forms;

namespace HelloWorld
{
    public partial class DataAccessPage : ContentPage
    {
        public DataAccessPage()
        {
            InitializeComponent();

            BindingContext = Application.Current;

            //if (Application.Current.Properties.ContainsKey(App.TitleKey))
            //{
            //    title.Text = Application.Current.Properties[App.TitleKey]?.ToString();
            //}

            //if (Application.Current.Properties.ContainsKey(App.NotificationEnabledKey))
            //{
            //    notificationsEnabled.On = (bool) Application.Current.Properties[App.NotificationEnabledKey];
            //}

            //var app = Application.Current as App;
            //title.Text = app.Title;
            //notificationsEnabled.On = app.NotificationEnabled;
        }

        //private async void OnChanged(object sender, EventArgs e)
        //{
        //    //Application.Current.Properties[App.TitleKey] = title.Text;
        //    //Application.Current.Properties[App.NotificationEnabledKey] = notificationsEnabled.On;

        //    //await Application.Current.SavePropertiesAsync();

        //    var app = Application.Current as App;
        //    app.Title = title.Text;
        //    app.NotificationEnabled = notificationsEnabled.On;
        //}

        protected override void OnDisappearing()
        {
            // Save property
            base.OnDisappearing();
        }
    }
}

