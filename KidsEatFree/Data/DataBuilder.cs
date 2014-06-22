using System;
using System.Collections.Generic;
using System.Linq;

namespace KidsEatFree
{
	public class DataBuilder
	{
		public DataBuilder ()
		{
		}

		public static List<Restaurant> SeedData() {

			List<Restaurant> Restaurants = new List<Restaurant> ();

			Restaurant r = new Restaurant ();
			r.Name = "7 Rivers: A Texas Kitchen (BBQ)";
			r.Detail = "Wednesday 4 pm to close, one free kid’s meal (12 years and under) with each entree purchased.";
			r.Locations.Add (new Location () { Street = "1855 Barker Cypress", City = "Houston", Phone = "(281) 480-2237", Lat=29.795538,Long=-95.689095 });
			r.Days.Add (new Day () { DayName = "Wed", Hours = "4 pm to close" });

			Restaurants.Add (r);

			r = new Restaurant ();
			r.Name = "Abe’s Cajun Market & Café";
			r.Detail = "Kids 12 and under eat free on Mondays with each purchase of an adult entree.";
			r.Locations.Add (new Location () { Street = "1080 Clear Lake City Boulevard", City = "Houston", Phone = "(281) 480-2237", Lat=29.580748,Long=-95.155814 });
			r.Days.Add (new Day () { DayName = "Mon", Hours = "" });

			Restaurants.Add (r);

			r = new Restaurant ();
			r.Name = "Antonia’s Italian Ristorante";
			r.Detail = "Sunday 11 am – 3 pm only.";
			r.Locations.Add (new Location () { Street = "26281 Northwest Freeway", City = "Cypress", Phone = "(281) 256-2796", Lat=29.972724,Long=-95.70172 });
			r.Locations.Add (new Location () { Street = "4849 Sweetwater Boulevard", City = "Sugarland", Phone = "(281) 265-4000", Lat=29.58672,Long=-95.632598 });
			r.Locations.Add (new Location () { Street = "2001 Katy Mills Boulevard", City = "Katy", Phone = "(281) 644-6000", Lat=29.783629,Long=-95.80615 });
			r.Days.Add (new Day () { DayName = "Sun", Hours = "11 - 3" });

			Restaurants.Add (r);

			r = new Restaurant ();
			r.Name = "Ashiana Indian Restuarant";
			r.Detail = "Kids 10 and under eat free Sundays with each purchase of adult entree.";
			r.Locations.Add (new Location () { Street = "12610 Briar Forest", City = "Houston", Phone = "(281) 679-5555", Lat=29.754646,Long=-95.610819 });
			r.Days.Add (new Day () { DayName = "Sun", Hours = "" });
			Restaurants.Add (r);

			r = new Restaurant ();
			r.Name = "The Backyard Grill";
			r.Detail = "Kids 12 and under eat free Wednesdays with each purchase of adult entree.";
			r.Locations.Add (new Location () { Street = "9453 Jones Road", City = "Houston", Phone = "(281) 897-9200", Lat=29.909263,Long=-95.585949 });
			r.Days.Add (new Day () { DayName = "Wed", Hours = "" });
			Restaurants.Add (r);

			r = new Restaurant ();
			r.Name = "The Backyard Smokehouse";
			r.Detail = "Kids 12 and under eat free Wednesdays with each purchase of adult entree.";
			r.Locations.Add (new Location () { Street = "13802 Fleur de Lis Boulevard", City = "Houston", Phone = "(281) 469-3485", Lat=29.938862,Long=-95.629368 });
			r.Days.Add (new Day () { DayName = "Wed", Hours = "" });
			Restaurants.Add (r);

			r = new Restaurant ();
			r.Name = "Bayou City Wings";
			r.Detail = "All Houston Locations. Kids 12 and under eat free Sundays with each purchase of an adult entree.";
			r.Days.Add (new Day () { DayName = "Sun", Hours = "" });
			Restaurants.Add (r);

			r = new Restaurant ();
			r.Name = "Berryhill Baja Grill";
			r.Detail = "Kids under 10 eat free all day Tuesday. One free kid’s meal per adult entree or combo.";
			r.Locations.Add (new Location () { Street = "9595 Six Pines Drive", City = "The Woodlands", Phone = "(281) 298-8226", Lat=30.164569,Long=-95.465391 });
			r.Locations.Add (new Location () { Street = "731 Memorial City Way", City = "Houston", Phone = "(713) 932-8226", Lat=29.781694,Long=-95.536039 });
			r.Locations.Add (new Location () { Street = "5110 Buffalo Speedway", City = "Houston", Phone = "(713) 667-8226", Lat=29.72782,Long=-95.429044 });
			r.Locations.Add (new Location () { Street = "1717 Post Oak Blvd", City = "Houston", Phone = "(713) 871-8226", Lat=29.749169,Long=-95.459765 });
			r.Locations.Add (new Location () { Street = "2639 Revere Street", City = "Houston", Phone = "(713) 526-8080", Lat=29.742263,Long=-95.416398 });
			r.Days.Add (new Day () { DayName = "Tue", Hours = "" });
			Restaurants.Add (r);

			r = new Restaurant ();
			r.Name = "Black-eyed Pea";
			r.Detail = "All 11 Houston-area locations. Free kid’s meal Tuesday, 4 pm to close, with purchase of each adult entree.";
			r.Days.Add (new Day () { DayName = "Tue", Hours = "" });
			Restaurants.Add (r);

			r = new Restaurant ();
			r.Name = "Black Jack’s Bar & Grill";
			r.Detail = "Kids 12 and under eat free Wednesdays with each purchase of adult entree.";
			r.Locations.Add (new Location () { Street = "16103 West Little York", City = "Houston", Phone = "(281) 858-6500", Lat=29.866938,Long=-95.653013 });
			r.Days.Add (new Day () { DayName = "Wed", Hours = "" });
			Restaurants.Add (r);

			r = new Restaurant ();
			r.Name = "Boudreaux’s Cajun Kitchen";
			r.Detail = "Kids eat free Tuesdays with purchase of an adult item $6.95 or higher.";
			r.Locations.Add (new Location () { Street = "9774 Katy Freeway", City = "Houston", Phone = "(713) 463-0099", Lat=29.785615,Long=-95.536728 });
			r.Locations.Add (new Location () { Street = "12806 Gulf Freeway", City = "Houston", Phone = "(281) 464-6800", Lat=29.61387,Long=-95.214854 });
			r.Locations.Add (new Location () { Street = "5375 W. Loop South", City = "Houston", Phone = "(713) 838-2200",Lat=29.726349,Long=-95.417743 });
			r.Locations.Add (new Location () { Street = "100 Gulfgate Center", City = "Houston", Phone = "(713) 643-5000", Lat=29.6985,Long=-95.297243 });
			r.Locations.Add (new Location () { Street = "17595 Tomball Parkway", City = "Houston", Phone = "(281) 469-8500", Lat=29.956889,Long=-95.543677 });
			r.Days.Add (new Day () { DayName = "Tue", Hours = "" });
			Restaurants.Add (r);

			r = new Restaurant ();
			r.Name = "(The) Cajun Shop";
			r.Detail = "Children 12 and under can enjoy a free kid’s meal Tuesdays with any paying adult.  NOTE: Must ask your server for it at the time of ordering.";
			r.Locations.Add (new Location () { Street = "2130 Jefferson St.", City = "Houston", Phone = "(713) 222-8333", Lat=29.744795, Long=-95.359905 });
			r.Days.Add (new Day () { DayName = "Tue", Hours = "" });
			Restaurants.Add (r);

			r = new Restaurant ();
			r.Name = "Candelari’s Pizzaria";
			r.Detail = " Cypress location only. Kids 10 and under eat free Mondays – Wednesdays with each purchase of an adult entree or pizza.";
			r.Locations.Add (new Location () { Street = "25680 Northwest Freeway", City = "Cypress", Phone = "(281) 373-0039", Lat=29.969104,Long=-95.689899 });
			r.Days.Add (new Day () { DayName = "Mon", Hours = "" });
			r.Days.Add (new Day () { DayName = "Tue", Hours = "" });
			r.Days.Add (new Day () { DayName = "Wed", Hours = "" });
			Restaurants.Add (r);

			r = new Restaurant ();
			r.Name = "Crabby Daddy Seafood and Steakhouse";
			r.Detail = "Kids eat free Mondays with adult entree purchase greater than $14.99.";
			r.Locations.Add (new Location () { Street = "25186 I-45 N", City = "Woodlands", Phone = "(281) 296-2722", Lat=30.127359,Long=-95.4409 });
			r.Days.Add (new Day () { DayName = "Mon", Hours = "" });
			Restaurants.Add (r);

			r = new Restaurant ();
			r.Name = "Zachary’s Cajun Cafe";
			r.Detail = "Kids eat free Saturdays 11 am – 4 pm with purchase of adult meal.";
			r.Locations.Add (new Location () { Street = "716 Kingwood Drive", City = "Kingwood", Phone = "(281) 359-225", Lat=30.050693,Long=-95.245111 });
			r.Days.Add (new Day () { DayName = "Sat", Hours = "11 - 4" });
			Restaurants.Add (r);

			r = new Restaurant ();
			r.Name = "Texas Roadhouse";
			r.Detail = "Valid only at the Spring location.  Two free kids’ meals Tuesdays per paid adult entree 4 pm to close.";
			r.Locations.Add (new Location () { Street = "124 FM1960 East", City = "Spring", Phone = "(281) 821-7427", Lat=30.020547,Long=-95.427823 });
			r.Days.Add (new Day () { DayName = "Tue", Hours = "4 - close" });
			Restaurants.Add (r);

			r = new Restaurant ();
			r.Name = "Wunsche Bros Cafe";
			r.Detail = "Kids 12 and under eat free on Mondays with each purchase of adult entree.";
			r.Locations.Add (new Location () { Street = "103 Midway", City = "Old Town Spring", Phone = "(281) 350-1902" });
			r.Days.Add (new Day () { DayName = "Mon", Hours = "" });
			Restaurants.Add (r);

			return (from x in Restaurants select x).OrderBy(z => z.Name).ToList();
		}
	}
}

