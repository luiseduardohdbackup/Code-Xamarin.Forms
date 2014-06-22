using System;
using System.Collections.Generic;
using System.Collections;

namespace KidsEatFree
{
	public class Restaurant
	{
		public Restaurant() {
			Locations = new List<Location> ();
			Days = new List<Day> ();
		}

		public string Name { get; set; }
		public string Detail { get; set; }

		public List<Location> Locations { get; set; }
		public List<Day> Days { get; set; }
	}

	public class DayRestaurant : IEnumerable {

		public DayRestaurant() { 
			Restaurants = new List<Restaurant> ();
		}

		public string Day { get; set; }
		public int DayNum { get; set; }
		public List<Restaurant> Restaurants { get; set; }

		public IEnumerator GetEnumerator() {
			return Restaurants.GetEnumerator ();
		}


	}
}

