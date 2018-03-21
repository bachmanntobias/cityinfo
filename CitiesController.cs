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
            Console.WriteLine(true);


            return new JsonResult();    
        }
    }
}
