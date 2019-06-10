using System;

namespace SalarySlip
{
    class Accountant : Employee
    {
        private const double PERKS = 0.3;

        public Accountant(string name, string dateofjoin, double basicsalary)
            : base(name, dateofjoin, "Accountant", basicsalary) { }

        public double Perks
        {
            get { return _basicsalary * PERKS; }
        }

        public override double CalculateMonthlySalary()
        {
            double total = _basicsalary + Perks;
            return total;
        }

        public override double CalculateCTC()
        {
            double total = CalculateMonthlySalary() * 12;
            return total;
        }

        public override string ToString()
        {
            return base.ToString() + "\nP:" + Perks + "\nMonthly Salary:" + CalculateMonthlySalary()
                +"\nCTC:"+CalculateCTC();
        }
    }
}
