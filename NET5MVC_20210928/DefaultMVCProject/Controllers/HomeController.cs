using DefaultMVCProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DefaultMVCProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        /// <summary>
        /// Get-Methode
        /// </summary>
        /// <returns></returns>
        /// 

        [HttpGet()]
        public IActionResult Index()
        {
            //Hier könnte ich weitere Daten zusammenführen und der Oberfläche (View) übergeben


            return View(); //Lieftert HTML an den Browser (Index-Seite) 
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ABC()
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
