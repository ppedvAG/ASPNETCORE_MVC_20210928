using ASPMVC_DependencyInjection_ServiceCollection_Samples.Models;
using ASPMVC_DependencyInjection_ServiceCollection_Samples.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ASPMVC_DependencyInjection_ServiceCollection_Samples.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITimeService _timeService;

        private readonly ICar _car; //vw-polo-2018

        public HomeController(ILogger<HomeController> logger, ITimeService timeService, ICar car)
        {
            _logger = logger;
            _timeService = timeService;
            _car = car;
        }

        public IActionResult ShowCar()
        {
            return View(_car); //Car
        }

        public IActionResult Index()
        {
            ViewData["AktullesDatum"] =  $"Aktuelles Datum {_timeService.GetDateTimeNow()}";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
