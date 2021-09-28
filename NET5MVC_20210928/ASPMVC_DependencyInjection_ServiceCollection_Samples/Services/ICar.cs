using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPMVC_DependencyInjection_ServiceCollection_Samples.Services
{
    public interface ICar
    {
        string Brand { get; set; }
        string Model { get; set; }
        int ConstructionYear { get; set; }
    }
}
