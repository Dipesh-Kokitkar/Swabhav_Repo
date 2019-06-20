using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPatternSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            IQueue<int> qnumbers = new QueueAdapter<int>();

            qnumbers.Enqueue(10);
            qnumbers.Enqueue(20);
            qnumbers.Enqueue(30);

            Console.WriteLine("Total count in queue:"+qnumbers.Count);
            Console.WriteLine("1st number is removed:"+qnumbers.Dequeue());
            Console.WriteLine("After remove count is :"+qnumbers.Count);

            Console.WriteLine();
            foreach (int item in qnumbers) {
                Console.WriteLine(item);
            }
            

        }
    }
}
