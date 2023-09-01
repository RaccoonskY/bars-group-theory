using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using solid_principles_practice.SRP;
using static solid_principles_practice.SRP.SRPGoodExample;






namespace solid_principles_practice.OCP
{
    /// <summary>
    ///  Данный класс представляет собой плохой пример Open Close Principle
    ///  EmployeeReport - класс, который закрыт расширения метода GenerateReport. 
    ///  Единственный способ добавить новый способ отчёта - изменить метод GenerateReport для обработки нового типа.
    ///  Альтернативное, хорошее согласно OCP решение, заключается в создании класса-интерфейса и его реализаций.
    /// </summary>
    internal class OpenCloseBadExample
    {
        public class EmployeeReport
        {
            // <summary>
            /// Тип отчета
            /// </summary>
            public string TypeReport { get; set; }

            /// <summary>
            /// Отчет по сотруднику
            /// </summary>
            public void GenerateReport(Employee em)
            {
                if (TypeReport == "CSV")
                {
                    // Генерация отчета в формате CSV
                }

                if (TypeReport == "PDF")
                {
                    // Генерация отчета в формате PDF
                }
            }
        }
    }
}
