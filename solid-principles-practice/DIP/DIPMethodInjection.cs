using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static solid_principles_practice.DIP.DIPExampleWithInterfaces;

namespace solid_principles_practice.DIP
{
    internal class DIPMethodInjection
    {
        public class Notification
        {
            public void DoNotify(IMessenger mes)
            {
                mes.Send();
            }
        }
    }
}
