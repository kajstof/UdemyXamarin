using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelloWorld;
using Xamarin.Forms;

namespace UdemyXamarin
{
    public partial class App : Application
    {
        private const string TitleKey = "Name";
        private const string NotificationEnabledKey = "NotificationEnabled";

        public App()
        {
            InitializeComponent();

            // List of all pages
            //MainPage = new NavigationPage(new WelcomePage());

            //MainPage = new NavigationPage(new WelcomePage()) {
            //    BarBackgroundColor = Color.Gray,
            //    BarTextColor = Color.White
            //};
            //MainPage = new ListViewPage();
            //MainPage = new TabbedExamplePage();
            //MainPage = new CarouselPage1();
            //MainPage = new PopupsPage();
            //MainPage = new NavigationPage(new ToolbarItemsPage());
            //MainPage = new NavigationPage(new InstagramAppExercisePage());
            //MainPage = new FormsPage();
            //MainPage = new NavigationPage(new Forms2Page());
            //MainPage = new NavigationPage(new ContactBookExerciseMainPage());
            //MainPage = new DataAccessPage();
            //MainPage = new SQLiteExamplePage();
            //MainPage = new RestfulServicePage();
            //MainPage = new NavigationPage(new ContactBookSQLiteExerciseMainPage());
            //MainPage = new NavigationPage(new NetflixRoulette());
            MainPage = new NavigationPage(new PlaylistsPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        public string Title
        {
            get
            {
                if (Properties.ContainsKey(TitleKey))
                {
                    return Properties[TitleKey]?.ToString();
                }

                return string.Empty;
            }
            set => Properties[TitleKey] = value;
        }

        public bool NotificationEnabled
        {
            get
            {
                if (Properties.ContainsKey(NotificationEnabledKey))
                {
                    return (bool) Properties[NotificationEnabledKey];
                }

                return false;
            }

            set => Properties[TitleKey] = value;
        }
    }
}
