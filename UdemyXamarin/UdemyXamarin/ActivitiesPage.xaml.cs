using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyXamarin.Models;
using UdemyXamarin.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UdemyXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActivitiesPage : MasterDetailPage
    {
        public ActivitiesPage()
        {
            InitializeComponent();

            var activityService = new ActivityService();
            listView.ItemsSource = activityService.GetActivities();
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //if (e.SelectedItem == null) { return; }
            //var activity = e.SelectedItem as Activity;
            //await Navigation.PushAsync(new ContactDetailPage(contact));
            //listView.SelectedItem = null;
            //Detail = new NavigationPage(new ContactDetailPage(activity));
            //IsPresented = false;    // IsMasterPresented
        }
    }
}