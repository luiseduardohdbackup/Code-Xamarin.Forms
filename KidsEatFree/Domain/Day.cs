using System;

namespace KidsEatFree
{
	public class Day
	{
		public string DayName { get; set; }
		public string Hours { get; set; }

		public int DayNum { 
			get { 
				switch (DayName) {
				case "Sun":
					return 0;
				case "Mon":
					return 1;
				case "Tue":
					return 2;
				case "Wed":
					return 3;
				case "Thu":
					return 4;
				case "Fri":
					return 5;
				case "Sat":
					return 6;
				}
				return 0;
			} 
		}
	}
}

