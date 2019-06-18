using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISPSolution
{
    class Manager : IWorker
    {
        public void StartEat()
        {
            Console.WriteLine("Manager is start eating");
        }

        public void StartWork()
        {
            Console.WriteLine("Manager start working");
        }

        public void StopEat()
        {
            Console.WriteLine("Manager stop eating");
        }

        public void StopWork()
        {
            Console.WriteLine("Manager  stop working");
        }
    }
}
