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
    public partial class ActivityFeedPage : ContentPage
    {
        public ActivityFeedPage()
        {
            InitializeComponent();
            var activityService = new ActivityService();
            activityFeedList.ItemsSource = activityService.GetActivities();
        }

        private async void activityFeedList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null) { return; }
            var activity = (e.SelectedItem as Activity);
            activityFeedList.SelectedItem = null;
            await Navigation.PushAsync(new UserProfilePage(activity.UserId));
        }
    }
}