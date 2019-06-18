using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleFactoryLib;

namespace AutoFactoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoMobileFactory factory = AutoMobileFactory.GetInstance();

            IAutomobile auto= factory.Make(AutoType.AUDI);
            auto.Start();
            auto.Stop();

            Type t = auto.GetType();
            Console.WriteLine(t);
        }
    }
}
