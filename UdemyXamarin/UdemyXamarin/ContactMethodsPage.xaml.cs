using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UdemyXamarin;
using Xamarin.Forms;

namespace HelloWorld
{
	public partial class ContactMethodsPage : ContentPage
	{
		public ContactMethodsPage()
		{
			InitializeComponent();

			listView.ItemsSource = new List<string>
			{
				"None",
				"Email",
				"SMS"
			};
		}

        public ListView ContactMethods { get => listView; }
    }
}

