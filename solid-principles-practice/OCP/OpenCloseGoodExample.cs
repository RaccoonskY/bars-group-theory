using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static solid_principles_practice.SRP.SRPGoodExample;

namespace solid_principles_practice.OCP
{
    internal class OpenCloseGoodExample
    {
        public class IEmployeeReport
        {
            /// <summary>
            /// Метод для создания отчета
            /// </summary>
            public virtual void GenerateReport(Employee em)
            {
                // Базовая реализация, которую нельзя модифицировать
            }
        }

        public class EmployeeCSVReport : IEmployeeReport
        {
            public override void GenerateReport(Employee em)
            {
                // Генерация отчета в формате CSV
            }
        }

        public class EmployeePDFReport : IEmployeeReport
        {
            public override void GenerateReport(Employee em)
            {
                // Генерация отчета в формате PDF
            }
        }


    }
}
