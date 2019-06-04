using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In main method");
            try { throw new MyException("DSK"); }
            catch (Exception e)
            {
                Console.WriteLine("Exception is catch here:" + e.ToString());
            }
        }
    }
}
