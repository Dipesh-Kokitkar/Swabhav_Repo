using System;

namespace SealedExApp
{
    class Dog:Animal
    {
        public Dog() {
            Console.WriteLine("Inside dog class");
        }

        public void Eat() {
            Console.WriteLine("Dog is eating");
        }
    }
}
