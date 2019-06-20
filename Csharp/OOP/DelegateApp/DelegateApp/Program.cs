using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateApp
{
    public delegate void DPrintMessage(string message);
    class Program
    {
        static void Main(string[] args)
        {
            DPrintMessage delegate1 = new DPrintMessage(PrintHello);
            DPrintMessage multicast=new DPrintMessage(PrintHello);
            delegate1("ABC");

            delegate1 = PrintGoodbye;
            delegate1("ABC");

            //delegate1 = Foo;
            PrintWizard(PrintHello);
            PrintWizard(PrintGoodbye);
            //PrintWizard(Foo);
            Console.WriteLine("Multicast");
            multicast += PrintGoodbye;
            multicast("ABC");
        }

        static void PrintHello(string name) {
            Console.WriteLine("Hello says {0}",name);
        }

        static void PrintGoodbye(string name) {
            Console.WriteLine("Goodbye says {0}",name);
        }

        static void Foo() {
            Console.WriteLine("This is foo class");
        }
        static void PrintWizard(DPrintMessage m) {
            m("Champ");
        }
    }
}
