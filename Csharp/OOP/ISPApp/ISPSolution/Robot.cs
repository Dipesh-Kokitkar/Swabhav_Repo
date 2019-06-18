using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISPSolution
{
    class Robot : IWork
    {
        public void StartWork()
        {
            Console.WriteLine("Robot start working");
        }

        public void StopWork()
        {
            Console.WriteLine("Robot stop Working");
        }
    }
}
