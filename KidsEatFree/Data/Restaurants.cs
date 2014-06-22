using System;
using System.Collections.Generic;
using System.Linq;

namespace KidsEatFree
{
	public static class Restaurants
	{
		public static List<Restaurant> Data { get; set; }

		public static List<DayRestaurant> ByDate { 
			get {

				List<DayRestaurant> data = new List<DayRestaurant> ();

				foreach (Restaurant r in Restaurants.Data) {
					foreach (Day d in r.Days) {

						if (d.DayName.Length > 0) {
							bool found = false;

							foreach (DayRestaurant dr in data) {
								if (dr.Day == d.DayName) {
									dr.Restaurants.Add (r);
									found = true;
									break;
								}
							}

							if (!found) {
								DayRestaurant dr = new DayRestaurant ();
								dr.Day = d.DayName;
								dr.DayNum = d.DayNum;
								dr.Restaurants.Add (r);
								data.Add (dr);
							}
						}
					}
				}

				data = (from x in data
				        select x).OrderBy (d => d.DayNum).ToList ();

				return data;
			}
		}
	}
}

