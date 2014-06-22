using System;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Linq;

namespace KidsEatFree
{
	public class DayList : ContentPage
	{
		public DayList ()
		{
			Title = "By Day";

			Restaurant restaurant = new Restaurant ();

			ListView lv = new ListView ();
			lv.IsGroupingEnabled = true;
			lv.GroupDisplayBinding = new Binding ("Day");
			lv.GroupHeaderTemplate = null;

			lv.ItemTemplate = new DataTemplate (typeof(TextCell)) 
			{ Bindings = {
					{ TextCell.TextProperty, new Binding("Name") }, 
					{ TextCell.DetailProperty, new Binding("Detail") } 
				}
			};

			lv.ItemsSource = Restaurants.ByDate;

			EntryCell ec = new EntryCell ();
			ec.BindingContext = Restaurants.Data [0];
			ec.SetBinding (EntryCell.TextProperty, "Name");

			lv.ItemTapped += HandleItemTapped;
			this.Content = lv;
		}

		void HandleItemTapped (object sender, ItemTappedEventArgs e)
		{
			Navigation.PushAsync (new DetailView ((Restaurant)e.Item));
		}
	}
}

