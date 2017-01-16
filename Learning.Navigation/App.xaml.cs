using Xamarin.Forms;

namespace Learning.Navigation
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new  Learning_NavigationPage());
			//MainPage = new Learning_NavigationPage();

			//MainPage = new  MenePage();
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
