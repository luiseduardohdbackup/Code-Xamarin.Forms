using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Maps;

namespace KidsEatFree.Android
{
	[Activity (Label = "KidsEatFree.Android.Android", MainLauncher = true)]
	public class MainActivity : AndroidActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			Restaurants.Data = DataBuilder.SeedData ();

			Xamarin.Forms.Forms.Init (this, bundle);
			Xamarin.FormsMaps.Init (this,bundle);

			SetPage (App.GetMainPage ());
		}
	}
}

