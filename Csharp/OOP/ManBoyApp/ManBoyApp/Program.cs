using System;
using ManBoyApp.Constrctor.Case1;

namespace ManBoyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Case1();
            //Case2();
            //Case3();
            //Case4();
            //Case5();
            Case6();
        }

        static void Case1() {
            Man man;
            man = new Man();
            man.play();
            man.Walk();
        }

        static void Case2() {
            Boy boy;
            boy = new Boy();
            boy.play();
            boy.eat();
            boy.Walk();

        }

        static void Case3() {
            Man man;
            man = new Boy();
            man.Walk();
            man.play();
        }

        static void Case4() {
            AtThePark(new Man());
            AtThePark(new Boy());
            AtThePark(new Kid());
            AtThePark(new Infant());
        }

        static void Case5() {
           new Child();
        }

        static void Case6() {
            Constrctor.Case2.Child child1 = new Constrctor.Case2.Child();
            Console.WriteLine("bar1:"+child1.Bar);

            Constrctor.Case2.Child child2 = new Constrctor.Case2.Child(200);
            Console.WriteLine("bar2:"+child2.Bar);
        }

        static void AtThePark(Man man) {
            Console.WriteLine("Inside the park");
            man.play();
        }
    }
}
