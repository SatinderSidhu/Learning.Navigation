using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Learning.Navigation
{
	public partial class Page1ContentPage : ContentPage
	{
		public Page1ContentPage()
		{
			InitializeComponent();
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			var page = new Page2();

			NavigationPage.SetBackButtonTitle(page, "Hmm");
			Navigation.PushAsync(page);
		}
	}
}
