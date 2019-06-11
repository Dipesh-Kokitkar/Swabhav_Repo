using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CollectionApp;

namespace CollectionApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Case3();
            //Case4();
            Case5();
        }

        static void Case3() {
            HashSet<LineItem> cart = new HashSet<LineItem>(new ObjectComparar());

            cart.Add(new LineItem("book",2,500));
            cart.Add(new LineItem("book", 2, 500));
            cart.Add(new LineItem("notebook", 2, 500));

            Console.WriteLine("Size:"+cart.Count);
        }

        static void Case4() {
            HashSet<Student> school = new HashSet<Student>(new EqulityCheck());

            school.Add(new Student(1001,10,"abc"));
            school.Add(new Student(1001,10,"xyz"));
            Console.WriteLine("Size:"+school.Count);
        }

        static void Case5() {
            Dictionary<Student, Student> school = new Dictionary<Student, Student>(new DictionaryEqualityCheck());

            school.Add(new Student(1001, 10, "Abc"), new Student(1001, 10, "Abc"));
            Console.WriteLine(school.ContainsKey(new Student(1001,10,"Abc")));
            //school.Add(new Student(1002, 10, "Abc"), new Student(1002, 10, "Abc"));

            Console.WriteLine("Size:"+school.Count);

        }
    }
}
