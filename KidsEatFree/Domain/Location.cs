using System;

namespace KidsEatFree
{
	public class Location
	{

		public string Street { get; set; }
		public string City { get; set; }
		public string Zip { get; set; }
		public string Phone { get; set; }
		public double Lat { get; set; }
		public double Long { get; set; }

		public string Address { 
			get {
				return Street + " " + City;
			}
		}
	}
}

