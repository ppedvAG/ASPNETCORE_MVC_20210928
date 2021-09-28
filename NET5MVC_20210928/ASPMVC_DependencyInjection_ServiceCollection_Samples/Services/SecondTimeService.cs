using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPMVC_DependencyInjection_ServiceCollection_Samples.Services
{
    public class SecondTimeService : ITimeService
    {
        public DateTime GetDateTimeNow()
        {
            return new DateTime(2011, 11, 11, 11, 11, 11);
        }
    }
}
