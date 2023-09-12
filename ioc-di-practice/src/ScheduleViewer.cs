using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioc_di_practice.src
{
    public class ScheduleViewer
    {

        private IScheduleManager _scheduleManager;

        public ScheduleViewer(IScheduleManager scheduleManager)
        {
            _scheduleManager = scheduleManager;
        }


        public void RenderSchedule() {

            var schedule = _scheduleManager.GetSchedule();
            Console.WriteLine(schedule);
        }

    }
}
