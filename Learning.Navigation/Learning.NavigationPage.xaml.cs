using Xamarin.Forms;

namespace Learning.Navigation
{
	public partial class Learning_NavigationPage : ContentPage
	{
		public Learning_NavigationPage()
		{
			InitializeComponent();


		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			var page = new Page1ContentPage();
			Navigation.PushAsync(page);
			NavigationPage.SetHasBackButton(page, true);
			//NavigationPage.SetHasNavigationBar(page, false);
			//NavigationPage.SetBackButtonTitle(page, "Back");
		}

		void Handle_Clicked2(object sender, System.EventArgs e)
		{
			var page = new Page2();
			Navigation.PushAsync(page);
			NavigationPage.SetHasBackButton(page, true);
			//NavigationPage.SetHasNavigationBar(page, false);
			//NavigationPage.SetBackButtonTitle(page, "Back");
		}

		void Handle_ClickedList(object sender, System.EventArgs e)
		{
			var page = new MenuPage();
			Navigation.PushAsync(page);

		}



	}
}
