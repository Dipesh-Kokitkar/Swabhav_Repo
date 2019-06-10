using System;
namespace CollageApp.Entity
{
    class Professor:Person,ISalariedEmployee
    {
        private const double TA = 0.3;
        private const double BONUS = 0.5; 
        private double _basicsalary=30000; 

        public Professor(string name,string dateofbirth,string address)
            :base(name,dateofbirth,address) { }

        public double CalculateSalary()
        {
            return _basicsalary + (_basicsalary * TA) + (_basicsalary * BONUS);
        }
    }
}
