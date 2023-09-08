using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principles_practice.Sandbox
{
    internal class FastHuman :IHuman
    {
        public void Eat()
        {
            Console.WriteLine("Human eats fast");
        }

        public void Move()
        {
            Console.WriteLine("Human runs");
        }

        public void Think()
        {
            Console.WriteLine("Human thinks fast");
        }
    }
}
