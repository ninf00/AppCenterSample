using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;


namespace AppCenterSample
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new AppCenterSample.MainPage();
		}

		protected override void OnStart ()
		{
            // Handle when your app starts
            AppCenter.Start($"uwp=2872eb4d-7872-44cb-91b0-8fb0fe5ff382;android=1f8b163a-4441-49a9-875c-6a5f51edd220;ios=879af77d-a42c-4bc9-b113-e7ab5d57dbcd",
                typeof(Analytics), typeof(Crashes));
        }

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
