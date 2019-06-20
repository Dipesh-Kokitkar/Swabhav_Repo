using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethodLib2
{
    internal class Tesala : IAutomobile
    {
        public void start()
        {
            Console.WriteLine("Tesala started");
        }

        public void stop()
        {
            Console.WriteLine("Tesala stopped");
        }
    }
}
