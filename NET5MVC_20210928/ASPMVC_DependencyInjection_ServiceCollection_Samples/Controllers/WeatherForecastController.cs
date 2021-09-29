using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPMVC_DependencyInjection_ServiceCollection_Samples.Controllers
{
    public class WeatherForecastController : Controller
    {
        //Service wird hier herbeigezogen (Seperate of Concerne)
        public IActionResult Index()
        {

            //Lese Wetterdaten aus 


            return View(/*Übergene Wetterdaten an View*/);
        }
    }
}
