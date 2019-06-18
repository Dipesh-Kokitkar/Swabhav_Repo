using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISPVoilation
{
    class Program
    {
        static void Main(string[] args)
        {
            AtCafetearea(new Manager());
            AtWorkStation(new Manager());

            AtCafetearea(new Robot());
            AtWorkStation(new Robot());
        }

        static void AtCafetearea(IWorker worker) {
            Console.WriteLine("At Cafeate Area!");
            try
            {
                worker.StartEat();
                worker.StopEat();
            }
            catch (Exception e) {
                Console.WriteLine("Message:"+e.Message);
            }

        }

        static void AtWorkStation(IWorker worker) {
            Console.WriteLine("At Workstation!");
            try
            {
                worker.StartWork();
                worker.StopWork();
            }
            catch(Exception e) {
                Console.WriteLine("Message:"+e.Message);
            }
        }
    }
}
