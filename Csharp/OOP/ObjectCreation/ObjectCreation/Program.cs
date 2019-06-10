using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectCreation
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student1 = (Student)Activator.CreateInstance(typeof(Student));
            Console.WriteLine("Roll Number:"+student1.RollNumber+"\nName:"+student1.Name);

            Student student2 = student1;
            Console.WriteLine();
            Console.WriteLine("Roll Number:" + student2.RollNumber + "\nName:" + student2.Name);

        }
    }
}
