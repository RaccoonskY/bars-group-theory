using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioc_di_practice.src
{
    public class ScheduleManager : IScheduleManager
    {
        public string GetSchedule()
        {
            return "1 - Physics\n2 - PE";
        }
    }
}
