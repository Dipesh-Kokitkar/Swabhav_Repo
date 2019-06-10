using System;
using InterfaceApp.Curd;
using InterfaceApp.Vehicle;

namespace InterfaceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Case1();
            Case2();
        }

        static void Case1() {
            DoDatabaseOpertion(new CustmerDB());
            DoDatabaseOpertion(new DpartmentDB());
            DoDatabaseOpertion(new Invoice());
        }

        static void Case2() {
            IMoveable[] moveable= new IMoveable[3];

            moveable[0] = new Car();
            moveable[1] = new Bike();
            moveable[2] = new Truck();

            StartRace(moveable);
        }

        static void DoDatabaseOpertion(ICurdable crud) {
            Console.WriteLine(crud.Create());
            Console.WriteLine(crud.Read());
            Console.WriteLine(crud.Update());
            Console.WriteLine(crud.Delete());
            Console.WriteLine();
        }

        static void StartRace(IMoveable[] moveable) {
            foreach(IMoveable move in moveable)
                Console.WriteLine(move.Move());
        }
    }
}
