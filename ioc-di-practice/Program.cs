using ioc_di_practice.src;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioc_di_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IKernel ninjectKernel = new StandardKernel(new NinjectConfigModule());
            ScheduleViewer scheduleViewer = ninjectKernel.Get<ScheduleViewer>();

            scheduleViewer.RenderSchedule();
            
        }
    }
}
