using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionStackTrac
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Method1();
            }
            catch (Exception e) {
                Console.WriteLine("Message:"+e.Message);
            }
            Console.WriteLine("End of Main");
        }

        static void Method1() {
            Console.WriteLine("Inside Method1");
            Method2();
        }

        static void Method2() {
            Console.WriteLine("Inside method2");
            Method3();
        }

        static void Method3() {
            Console.WriteLine("Inside Method3");
            throw new Exception("Method3 has error");
        }
    }
}
