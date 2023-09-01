using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principles_practice.SRP
{
    internal class SRPBadExample
    {
        public class Employee
        {
            public int ID { get; set; }
            public string FullName { get; set; }

            /// <summary>
            /// Данный метод добавляет в БД нового сотрудника
            /// </summary>
            /// <param name="em">Объект для вставки</param>
            /// <returns>Результат вставки новых данных</returns>
            public bool Add(Employee emp)
            {
                // Вставить данные сотрудника в таблицу БД
                return true;
            }

            /// <summary>
            /// Отчет по сотруднику
            /// </summary>
            public void GenerateReport(Employee em)
            {
                // Генерация отчета по деятельности сотрудника
            }
        }
    }
}
