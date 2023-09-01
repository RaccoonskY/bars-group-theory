using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principles_practice.ISP
{
    internal class ISPGoodExample
    {
        public interface IOperationAdd
        {
            bool AddDetailsEmployee();
        }

        public interface IOperationGet
        {
            bool ShowDetailsEmployee(int id);
        }
    }
}
