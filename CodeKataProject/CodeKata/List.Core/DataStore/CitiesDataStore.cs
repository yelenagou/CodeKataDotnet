using List.Core.DataTransformation;
using System;
using System.Collections.Generic;
using System.Text;

namespace List.Core.DataStore
{
	public class CitiesDataStore
	{
		public static CitiesDataStore Current { get; } = new CitiesDataStore();
		public List<CityDto> Cities { get; set; }
		public CitiesDataStore()
		{
			Cities = new List<CityDto>() {
				new CityDto()
				{
					Id = 1,
					Name = "New York City",
					Description = "The one with big park",
					PointsOfInterest = new List<PointOfInterestDto>()
					{
						new PointOfInterestDto() { 
							 Id = 1,
							 Name = "Central Park",
							  Description = "Big Park"
						},
						new PointOfInterestDto() {
							 Id = 2,
							 Name = "Greenwhich Village",
							  Description = "Area with all the bars and restaurants"
						}
					}
				},
				new CityDto()
				{
					Id = 2,
					Name = "Antwerp",
					Description = "The one with the cathedral that was not finished",
					PointsOfInterest = new List<PointOfInterestDto>()
					{
						new PointOfInterestDto() {
							 Id = 3,
							 Name = "Cathedral of Our Lady",
							  Description = "A Gothic style cathedral, conceived by architects Jan"
						},
						new PointOfInterestDto() {
							 Id = 4,
							 Name = "Greenwhich Village",
							  Description = "Finest railroad architecture in Belgium"
						}
					}
				},
				new CityDto()
				{
					Id = 3,
					Name = "Paris",
					Description = "The one with big tower",
					PointsOfInterest = new List<PointOfInterestDto>()
					{
						new PointOfInterestDto() {
							 Id = 5,
							 Name = "Louve",
							  Description = "Museum with Mona Lisa"
						},
						new PointOfInterestDto() {
							 Id = 6,
							 Name = "Eifel Tower",
							  Description = "Built for World Fair"
						}
					}
				}
			};
		}
	}
}
