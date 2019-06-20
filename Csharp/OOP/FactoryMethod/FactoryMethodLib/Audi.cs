using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethodLib2
{
    internal class Audi : IAutomobile
    {
        public void start()
        {
            Console.WriteLine("Audi started");
        }

        public void stop()
        {
            Console.WriteLine("Audi stopped");
        }
    }
}
