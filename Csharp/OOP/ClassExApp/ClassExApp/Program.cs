using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExApp
{
    class Program
    {
        private int rollno;
        private string name, city;

        Program(int rollno,string name,string city) {
            this.rollno = rollno;
            this.name = name;
            this.city = city;
        }
        void DisplayInfo() {
            Console.WriteLine("Student Info==>");
            Console.WriteLine("Roll Number:"+rollno+"\nName:"+name+"\nCity:"+city);
        }
        static void Main(string[] args)
        {
            Program P = new Program(1,"ABC","Thane");
            P.DisplayInfo();
        }
    }
}
