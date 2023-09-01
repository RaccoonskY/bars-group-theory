using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static solid_principles_practice.LCP.LCPBadExample;

namespace solid_principles_practice.LCP
{
    internal class LiskovDemo
    {
        static public void Demo(string[] args)
        {
            List<Employee> list = new List<Employee>();

            list.Add(new JuniorEmployee());
            list.Add(new SeniorEmployee());

            foreach (Employee emp in list)
            {
                emp.GetEmployeeDetails(985);
            }
        }
    }
}

