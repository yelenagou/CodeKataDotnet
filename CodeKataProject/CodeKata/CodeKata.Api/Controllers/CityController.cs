using List.Core.DataStore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeKata.Api.Controllers
{
	[ApiController]
	[Route("api/cities")]
	public class CityController : ControllerBase
	{
		/// <summary>
		/// json Result is an action result that returns json
		/// </summary>
		/// <returns></returns>
		[HttpGet]
		public IActionResult GetCities()
		{
			return Ok(CitiesDataStore.Current.Cities);
		}
		[HttpGet("{id}")]
		public IActionResult GetCity(int id)
		{
			var cityToReturn = CitiesDataStore.Current.Cities.FirstOrDefault(r => r.Id == id);
			if (cityToReturn == null)
			{
				return NotFound();
			}
			return Ok(cityToReturn);
			//return new JsonResult(CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id));
		}
	}
}
