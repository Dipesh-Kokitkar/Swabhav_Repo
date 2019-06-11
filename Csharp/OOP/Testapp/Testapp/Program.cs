using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security.Policy;

namespace Testapp
{
    class Program
    {
        static void Main(string[] args)
        {
           // Url url = new Url();
            
           StreamReader reader = new StreamReader(WebRequest.Create("https://swabhav-tech.firebaseapp.com/emp.txt").GetResponse().GetResponseStream());
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }
        }
    }
}
