using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NET5MVC_RazorSamples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace NET5MVC_RazorSamples.Controllers
{
    public class StateManagementController : Controller
    {
        public IActionResult ViewDataSample()
        {
            ViewData["abc"] = "Hallo liebe Teilnehmer";
            ViewData["def"] = "Aus das wird mit übergeben";
            
            
            
            return View();
        }


        public IActionResult ViewBagSample()
        {
            //Intern wird ViewData verwenden -> ViewData["GHJ"] = "Hallo liebe Teilnehmer, ich bin ViewBag, die schlechte Kopie von ViewData";
            ViewBag.GHJ = "Hallo liebe Teilnehmer, ich bin ViewBag, die schlechte Kopie von ViewData";
            return View();
        }

        public IActionResult TempDataSample()
        {
            TempData["EmailAddress"] = "KevinW@ppedv.de";
            TempData["Id"] = 123;

            return View();
        }

        public IActionResult TempDataSecondSample()
        {
            return View();
        }

        public IActionResult TempDataThirdSample()
        {
            return View();
        }

        public IActionResult SessionStart()
        {
            //Achtung using  Microsoft.AspNetCore.Http; verwenden!!!!!!!!!!!!!! -> SetInt32 UND SetString
            HttpContext.Session.SetInt32("Lottozahlen", 1234567);
            HttpContext.Session.SetString("Lottogewinner", "Otto Walkes");

            Person person = new Person("Muster", 32, "Muster@ppedv.de");
            
            string jsonString = JsonSerializer.Serialize(person);
            HttpContext.Session.SetString("PersonObj", jsonString);

            return View();
        }


        public IActionResult SessionResult()
        {
            int? lottozahlen = HttpContext.Session.GetInt32("Lottozahlen");
            string name = HttpContext.Session.GetString("Lottogewinner");

            return View();
        }


    }
}
