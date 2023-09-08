using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principles_practice.Sandbox
{
    internal class SimpleHuman : IHuman
    {
        public void Eat()
        {
            Console.WriteLine("Human just eats");
        }

        public void Move()
        {
            Console.WriteLine("Human just moves");
        }

        public void Think()
        {
            Console.WriteLine("Human just thinks");
        }
    }
}
