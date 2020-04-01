using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using List.Core.DataStore;

namespace CodeKata.Api.Controllers
{
    [Route("api/cities/{cityId}/pointsofinterest")]
    [ApiController]
    public class PointsOfInterestController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetPointsOfInterest(int cityId)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);
            if (city == null)
            { return NotFound(); }

            return Ok(city.PointsOfInterest);
           
        }
        [HttpGet("{id}")]
        public IActionResult GetPointOfInterest(int cityId, int id)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId && c.PointsOfInterest.FirstOrDefault().Id == id);
            if (city == null)
            { return NotFound(); }
            //var pos = city.PointsOfInterest.FirstOrDefault(p => p.Id == id);
            return Ok(city);

        }

    }
}