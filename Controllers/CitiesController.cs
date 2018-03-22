using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CityInfo.API 
{ 
    public class CitiesController : Controller
    {
        public JsonResult GetCities()
        {
            [ HttpGet("api/cities")]

            return new JsonResult(new List<object>()
            {
                new {id=1, Name="New York City"},
                new {id=2, Name="Antwerp"}
            }); 
        }
    }
}
/*
 * GET
 * POST
 * PUT
 * PATCH
 * DELETE
 * 
 */

