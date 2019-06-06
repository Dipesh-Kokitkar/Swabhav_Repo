using System;

namespace SealedExApp
{
    sealed class Animal
    {
        public Animal() {
            Console.WriteLine("Inside Animal class");
        }

        public void eat() {
            Console.WriteLine("Animal is eating");
        }
    }
}
