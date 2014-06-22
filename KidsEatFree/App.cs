using System;
using Xamarin.Forms;

namespace KidsEatFree
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			TabbedPage tabs = new TabbedPage ();

			tabs.Children.Add(new NavigationPage(new NameList()) { Icon = "48-fork-and-knife.png", Title = "By Name" });
			tabs.Children.Add(new NavigationPage(new DayList()) { Icon = "83-calendar.png", Title = "By Day" });
			tabs.Children.Add(new NavigationPage(new MapView()) { Icon = "103-map.png", Title = "Map" });

			return tabs;

		}
	}
}

