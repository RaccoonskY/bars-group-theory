using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principles_practice.ISP
{
    /// <summary>
    /// Вместо единого интерфейса мы разделяем потенциальные зависимости на два интерфейса
    /// Если классу не требуется для реализации ShowDetailsEmployee, он может реализовать необходимый интерфейс
    /// </summary>
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
