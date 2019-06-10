using System;

namespace InterfaceApp.Vehicle
{
    class Truck : IMoveable
    {
        public string Move()
        {
            return "Truck is moving!!";
        }
    }
}
