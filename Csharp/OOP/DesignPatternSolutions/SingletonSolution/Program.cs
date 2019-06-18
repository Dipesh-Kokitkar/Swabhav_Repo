using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            //Case1();
            Case2();
        }

        static void Case1() {
            /*DataServer dataserver1 = new DataServer();
            DataServer dataserver2 = new DataServer();

            dataserver1.DoSomething();
            dataserver2.DoSomething();

            Console.WriteLine(dataserver1.GetHashCode());
            Console.WriteLine(dataserver2.GetHashCode());*/
        }

        static void Case2() {
            DataServer dataserver1 = DataServer.GetInstance();
            DataServer dataserver2 = DataServer.GetInstance();

            dataserver1.DoSomething();
            dataserver2.DoSomething();
        }
    }
}
