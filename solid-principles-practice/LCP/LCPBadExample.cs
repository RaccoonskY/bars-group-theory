using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principles_practice.LCP
{
    internal class LCPBadExample
    {
        /// <summary>
        /// В этом примере не выполняется LSP. 
        /// имеем в наличие пару методов с имплементацией, 
        /// т.к. методы имеют реализацию, все последующие наследники также должны реализовывать эти методы
        /// иначе объект, не реализующий метод не выполняет LSP
        /// </summary>
        public abstract class Employee
        {
            public virtual string GetWorkDetails(int id)
            {
                return "Base Work";
            }

            public virtual string GetEmployeeDetails(int id)
            {
                return "Base Employee";
            }
        }

        public class SeniorEmployee : Employee
        {
            public override string GetWorkDetails(int id)
            {
                return "Senior Work";
            }

            public override string GetEmployeeDetails(int id)
            {
                return "Senior Employee";
            }
        }

        public class JuniorEmployee : Employee
        {
            // Допустим, для Junior’a отсутствует информация
            public override string GetWorkDetails(int id)
            {
                throw new NotImplementedException();
            }


            public override string GetEmployeeDetails(int id)
            {
                return "Junior Employee";

            }
        }
    }
}
