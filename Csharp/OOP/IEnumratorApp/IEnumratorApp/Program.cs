using System;
using System.Collections.Generic;
using System.Text;

namespace IEnumratorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> Days = new List<string>() { "Sunday","Monday","Tuesday","Wednesday","Thursday","Friday","Sat"};
            PrintUsingIEnumarable(Days);
            PrintUsingIEnumrator(Days);
        }

        static void PrintUsingIEnumarable(List<string> days) {
            Console.WriteLine();
            IEnumerable<string> show = (IEnumerable<string>)days;
            foreach(String day in show )
                Console.WriteLine(day);
        }

        static void PrintUsingIEnumrator(List<string> days) {
            Console.WriteLine();
            IEnumerator<string> show = (IEnumerator<string>)days;
            while (show.MoveNext()) {
                Console.WriteLine(show.Current);
            }
        }
    }
}
