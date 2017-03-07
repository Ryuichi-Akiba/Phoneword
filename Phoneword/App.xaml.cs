using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Phoneword
{
	public partial class App : Application
	{
		public static IList<string> PhoneNumbers { get; set; }

		public App()
		{
			InitializeComponent();
			PhoneNumbers = new List<string>();
			MainPage = new NavigationPage(new MainPage());
		}

		protected override void OnStart()
		{
			MobileCenter.Start(typeof(Analytics), typeof(Crashes));
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
