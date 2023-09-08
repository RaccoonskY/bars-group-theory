using solid_principles_practice.LCP;
using solid_principles_practice.Sandbox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principles_practice
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<IHuman> humans = new List<IHuman>();
            humans.Add(new SimpleHuman());
            humans.Add(new FastHuman());


            foreach (IHuman human in humans)
            {
                human.Move();

            }
        }

       
    }
}
