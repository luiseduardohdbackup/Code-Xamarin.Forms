using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using KidsEatFree;

namespace KidsEatFree.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		UIWindow window;

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			Restaurants.Data = DataBuilder.SeedData ();

			Forms.Init ();
			Xamarin.FormsMaps.Init ();

			foreach (Restaurant rr in Restaurants.Data) {
				foreach (Location l in rr.Locations) {
					Console.WriteLine (l.Address);
				}
			}


			window = new UIWindow (UIScreen.MainScreen.Bounds);
			
			window.RootViewController = App.GetMainPage ().CreateViewController ();
			window.MakeKeyAndVisible ();
			
			return true;
		}
	}
}

