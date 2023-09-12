using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioc_di_practice.src
{
    public class AnotherScheduleManager : IScheduleManager
    {
        public string GetSchedule()
        {
            return "I - PE\nII - Physics";
        }
    }
}
