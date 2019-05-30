using System;

namespace InheritanaceApp_Ass2
{
    class Student
    {
        protected int m1, m2;
        protected string name;
        public Student(string name, int m1, int m2)
        {
            this.name = name;
            this.m1 = m1;
            this.m2 = m2;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("marks of Science:" + m1);
            Console.WriteLine("marks of Maths:" + m2);
        }
    }
}
