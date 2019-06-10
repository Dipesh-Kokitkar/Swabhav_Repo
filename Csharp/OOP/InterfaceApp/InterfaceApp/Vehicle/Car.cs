using System;

namespace InterfaceApp.Vehicle
{
    class Car : IMoveable
    {
        public string Move()
        {
            return "Car is moving!!";
        }
    }
}
