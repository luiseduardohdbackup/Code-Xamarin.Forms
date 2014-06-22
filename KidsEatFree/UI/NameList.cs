using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace KidsEatFree
{
	public class NameList : ContentPage
	{
		public NameList ()
		{
			Title = "By Name";

			ListView list = new ListView ();

			list.ItemsSource = Restaurants.Data;
			list.ItemTemplate = new DataTemplate (typeof(TextCell)) 
			{ Bindings = {
					{ TextCell.TextProperty, new Binding("Name")},
					{ TextCell.DetailProperty, new Binding("Detail")}
				}
			};

			list.ItemTapped += HandleItemTapped;

			Content = list;
		}

		void HandleItemTapped (object sender, ItemTappedEventArgs e)
		{
			Navigation.PushAsync (new DetailView ((Restaurant)e.Item));
		}
	}
}

