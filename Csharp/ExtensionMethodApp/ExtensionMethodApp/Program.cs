using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethodApp
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            string old = "Swabhav Techlabs";
            string modified= old.SnakeCase();
            Console.WriteLine("Old string:"+old+"\n New:"+modified);
        }

    }
}
