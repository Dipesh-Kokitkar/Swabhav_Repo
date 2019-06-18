using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISPVoilation
{
    class Robot : IWorker
    {
        public void StartEat()
        {
            throw new NotImplementedException();
        }

        public void StartWork()
        {
            Console.WriteLine("Robot start working!");
        }

        public void StopEat()
        {
            throw new NotImplementedException();
        }

        public void StopWork()
        {
            Console.WriteLine("Robot Stop Working!");
        }
    }
}
