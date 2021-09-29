using Microsoft.AspNetCore.Mvc;
using NET5MVC_RazorSamples.Models;
using NET5MVC_RazorSamples.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NET5MVC_RazorSamples.Controllers
{
    public class RazorSyntaxSamplesController : Controller
    {
        //private readonly IWeatherForecastService _weatherForecastService;

        public RazorSyntaxSamplesController()
        {
            //_weatherForecastService = weatherForecastService;
        }
        public IActionResult Index()
        {
            IList<Person> myPersons = new List<Person>();

            myPersons.Add(new Person("Max", 33));

            myPersons.Add(new Person("Moritz", 34));


            //IList -> IEnumerable casten -> myPersons.ToArray()
            return View(myPersons.ToArray());
        }
    }
}
