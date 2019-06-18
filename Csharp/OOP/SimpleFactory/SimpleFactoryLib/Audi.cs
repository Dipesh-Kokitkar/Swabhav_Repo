using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactoryLib
{
    internal class Audi : IAutomobile
    {
        public void Start()
        {
            Console.WriteLine("Audi's car started");
        }

        public void Stop()
        {
            Console.WriteLine("Audi's car stoped");
        }
    }
}
