using System;

namespace HumanApp
{
    class Program
    {
        static void DisplayInfo(Human h)
        {
            Console.WriteLine("Infomation==>");
            Console.WriteLine("Name:" + h.GetName());
            Console.WriteLine("Height:" + h.GetHeight());
            Console.WriteLine("Weight:" + h.GetWeight());
            Console.WriteLine("Age:" + h.GetAge());
            Console.WriteLine("Gender:"+h.GetGender());
        }
        static void Main(string[] args)
        {
            Human H1 = new Human("ABC", 6.2f, 50.46f, 26,"F");
            Human H2 = new Human("XYZ", 5.0f, 38.4f);

            Console.WriteLine("\tInital state");
            DisplayInfo(H1);
            DisplayInfo(H2);

            Console.WriteLine("\tAfter Workout state");
            H1.Workout();
            H2.Workout();
            DisplayInfo(H1);
            DisplayInfo(H2);

            Console.WriteLine("\tAfter eating state");
            H1.Eat();
            H2.Eat();
            DisplayInfo(H1);
            DisplayInfo(H2);
        }
    }
}
