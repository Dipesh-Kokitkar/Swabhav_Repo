using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactoryLib
{
    internal class Tesala : IAutomobile
    {
        public void Start()
        {
            Console.WriteLine("Tesala's car started");
        }

        public void Stop()
        {
            Console.WriteLine("Tesala's car stoped");
        }
    }
}
