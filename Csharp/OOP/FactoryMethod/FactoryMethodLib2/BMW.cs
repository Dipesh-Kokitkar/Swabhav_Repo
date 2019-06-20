using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethodLib2
{
    internal class BMW : IAutomobile
    {
        public void start()
        {
            Console.WriteLine("BMW started");
        }

        public void stop()
        {
            Console.WriteLine("BMW stopped");
        }
    }
}
