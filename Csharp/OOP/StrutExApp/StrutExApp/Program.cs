using System;
using System.Collections.Generic;
using System.Text;

namespace StrutExApp
{
    public struct Student {
        public int rollno;
        public string name, city;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student S;
            S.rollno = 1;
            S.name = "ABC";
            S.city = "Thane";

            Console.WriteLine("Student Info==>");
            Console.WriteLine("Roll NO:"+S.rollno+"\nName:"+S.name+"\nCity:"+S.city);
        }
    }
}
