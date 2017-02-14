using Xamarin.Forms;

namespace Learning.Navigation
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			var navigationPage = new NavigationPage(new  Learning_NavigationPage());

			// Set the title color
			navigationPage.BarBackgroundColor = Color.Yellow;
			navigationPage.BarTextColor = Color.Blue;

		
			MainPage = navigationPage;

	
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
	}
}
