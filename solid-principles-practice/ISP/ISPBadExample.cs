using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principles_practice.ICP
{
    internal class ISPBadExample
    {
        public interface IEmployee
        {
            bool AddDetailsEmployee();
            bool ShowDetailsEmployee(int id);
        }
    }
}
