using ASPMVC_DependencyInjection_ServiceCollection_Samples.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPMVC_DependencyInjection_ServiceCollection_Samples.Controllers
{
    public class ConfigSampleController : Controller
    {
        private readonly IConfiguration _configuration;

        private readonly SampleWebSettings _sampleWebSettings;

        public ConfigSampleController(IConfiguration configuration, IOptions<SampleWebSettings> settingOptions) //Appsettings.json Zugriff wird hier verfügbar gemacht
        {
            _configuration = configuration;

            _sampleWebSettings = settingOptions.Value;
        }

        public IActionResult Index()
        {
            PositionOptions positionOptions = new PositionOptions();

            //Wir laden AppSettings -Positionen in die Model-Klasse PositionOptions
            _configuration.GetSection(PositionOptions.StringPosition).Bind(positionOptions);

            return View(positionOptions);
        }

        public IActionResult OptionSample()
        {
            return View(_sampleWebSettings);
        }
    }
}
