using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioc_di_practice.src
{
    internal class NinjectConfigModule : NinjectModule
    {

        public override void Load()
        {
           Bind<IScheduleManager>().To<AnotherScheduleManager>();

        }
    }
}
