using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principles_practice.DIP
{
    internal class DIPBadExamples
    {
        public class Email
        {
            public void Send()
            {
                // код для отправки email-письма
            }
        }

        // Уведомление
        public class Notification
        {
            private Email email;
            public Notification()
            {
                email = new Email();
            }

            public void EmailDistribution()
            {
                email.Send();
            }
        }
    }
}
