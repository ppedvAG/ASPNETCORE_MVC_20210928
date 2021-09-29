using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPMVC_DependencyInjection_ServiceCollection_Samples.Services
{
    public class Car : ICar
    {
        public string Brand { get; set; } = "VM";
        public string Model { get; set; } = "Polo";
        public int ConstructionYear { get; set; } = 2018;
    }
}
