using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyXamarin.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UdemyXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactDetailPage : ContentPage
    {
        public ContactDetailPage(Contact contact)
        {
            //if (contact == null)
            //{
            //    throw new ArgumentNullException();
            //}
            //BindingContext = contact;
            BindingContext = contact ?? throw new ArgumentNullException();
            InitializeComponent();
        }
    }
}