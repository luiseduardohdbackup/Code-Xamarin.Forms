using System;
using Xamarin.Forms;

namespace KidsEatFree
{
	public class DetailView : ContentPage
	{
		public Restaurant rest;

		public DetailView (Restaurant rest)
		{
			this.rest = rest;

			Title = rest.Name;

			StackLayout sl = new StackLayout ();

			sl.Children.Add(new Label() { Text = rest.Detail } );

			sl.Children.Add (new BoxView () { Color = Color.Black, WidthRequest = 20, HeightRequest = 2 });

			ListView lv = new ListView ();

			lv.ItemsSource = rest.Locations;
			lv.ItemTemplate = new DataTemplate (typeof(TextCell)) 
			{ Bindings = {
					{ TextCell.TextProperty, new Binding("Address")},
					{ TextCell.DetailProperty, new Binding("Phone")}
				}
			};

			lv.ItemTapped += HandleItemTapped;;
			sl.Children.Add (lv);

			this.Content = sl;
		}

		void HandleItemTapped (object sender, ItemTappedEventArgs e)
		{
			Navigation.PushAsync (new MapView (rest.Name, ((Location)e.Item).Phone, ((Location)e.Item).Address));
		}
	}
}

