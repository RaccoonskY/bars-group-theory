using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static solid_principles_practice.DIP.DIPExampleWithInterfaces;

namespace solid_principles_practice.DIP
{
    internal class DIPConstructorInjection
    {
        public class Notification
        {
            private IMessenger _messenger;
            public Notification(IMessenger mes)
            {
                _messenger = mes;
            }

            public void DoNotify()
            {
                _messenger.Send();
            }
        }
    }
}
