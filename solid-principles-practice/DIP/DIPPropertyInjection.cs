using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static solid_principles_practice.DIP.DIPExampleWithInterfaces;

namespace solid_principles_practice.DIP
{
    internal class DIPPropertyInjection
    {
        public class Notification
        {
            private IMessenger _messenger;
            public Notification()
            {

            }

            public IMessenger Messanger
            {
                set
                {
                    _messenger = value;
                }
            }

            public void DoNotify()
            {
                _messenger.Send();
            }
        }
    }
}
