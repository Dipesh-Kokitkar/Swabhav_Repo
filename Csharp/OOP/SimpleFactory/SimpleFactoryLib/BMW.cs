using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactoryLib
{
    internal class BMW : IAutomobile
    {
        public void Start()
        {
            Console.WriteLine("BMW's car started");
        }

        public void Stop()
        {
            Console.WriteLine("BMW's car stopped");
        }
    }
}
