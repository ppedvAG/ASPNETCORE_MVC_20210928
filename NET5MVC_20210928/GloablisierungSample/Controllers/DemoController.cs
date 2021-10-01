using GloablisierungSample.Resources;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GloablisierungSample.Controllers
{
    public class DemoController : Controller
    {
        private readonly IStringLocalizer<SharedResource> sharedResource;

        public DemoController(IStringLocalizer<SharedResource> _sharedResource)
        {
            sharedResource = _sharedResource;
        }
        public IActionResult Index()
        {
            var msg = sharedResource["Msg"];
            Debug.WriteLine("Msg: " + msg);

            var price = 1234567;
            Debug.WriteLine("Price: " + price.ToString("c"));

            var number = 1234567;
            Debug.WriteLine("Number: " + number.ToString("n"));

            var percent = 1234;
            Debug.WriteLine("Percent: " + percent.ToString("p"));

            var now = DateTime.Now;
            Debug.WriteLine("Date: " + now.ToString("F"));

            ViewBag.price = price;
            ViewBag.number = number;
            ViewBag.percent = percent;
            ViewBag.now = now;

            return View();
        }
    }
}
