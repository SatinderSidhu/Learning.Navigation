using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Learning.Navigation
{
	public partial class Page2 : ContentPage
	{
		public Page2()
		{
			InitializeComponent();

		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PopAsync(true);
		}

		void Handle_Clicked2(object sender, System.EventArgs e)
		{
			//Navigation.RemovePage(Navigation.NavigationStack);
		}
		void Handle_Clicked3(object sender, System.EventArgs e)
		{
			Navigation.PopToRootAsync(true);
		}
	}
}
