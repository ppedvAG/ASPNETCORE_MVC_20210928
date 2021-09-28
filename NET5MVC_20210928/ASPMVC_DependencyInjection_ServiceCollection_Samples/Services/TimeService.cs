using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPMVC_DependencyInjection_ServiceCollection_Samples.Services
{
    public class TimeService : ITimeService
    {
        public DateTime GetDateTimeNow()
        {
            return DateTime.Now;
        }
    }
}
