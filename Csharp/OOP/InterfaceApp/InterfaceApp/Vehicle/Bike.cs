using System;

namespace InterfaceApp.Vehicle
{
    class Bike : IMoveable
    {
        public string Move()
        {
            return "Bike is moving!!";
        }
    }
}
