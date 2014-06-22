using System;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace KidsEatFree
{
	public class MapView : ContentPage
	{
		Map map;
	
		public MapView(string name, string phone, string address) {
			map = new Map ();

			GetAddress (address, name);

			Content = map;
			Title = name;
		}

		public async void GetAddress(string addr, string name) {

			Geocoder gc = new Geocoder ();
			Task<IEnumerable<Position>> result = gc.GetPositionsForAddressAsync (addr);

			IEnumerable<Position> data = await result;

			foreach (Position p in data) {
				map.MoveToRegion(new MapSpan(p,.5,.5));
				map.Pins.Add (new Pin() { Address = addr, Label = name, Position = new Position(p.Latitude, p.Longitude) });
			}

		}

		public MapView ()
		{

			map = new Map ();
			Title = "Map";

			foreach (Restaurant r in Restaurants.Data) {
				foreach (Location l in r.Locations) {
					if (l.Lat != 0 && l.Long != 0) {
						map.Pins.Add (new Pin() { Address = l.Address, Label = r.Name, Position = new Position (l.Lat, l.Long) });
					}
				}
			}

			map.MoveToRegion (new MapSpan(map.Pins [0].Position, 1, 1));

			Content = map;
		}
	}
}

