using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentnames = {"Sanal","Akash","Dhurv","Priyak","Meet","Dipesh","Chirag"};
            IEnumerable<string> enumerablestudentname = studentnames;
            IEnumerable<string> enumerablenameswithA = enumerablestudentname.Where((n)=> {
                return n.Contains("a");
            }).OrderBy((n)=> n).Take(3);

            foreach (string student in enumerablenameswithA) {
                Console.WriteLine(student);
            }
        }
    }
}
