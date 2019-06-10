using System;

namespace SalarySlip
{
    class Developer : Employee
    {
        private const double BONUS = 0.4;
        private const double PA = 0.3;

        public Developer(string name, string dateofjoin, double basicsalary)
            : base(name, dateofjoin, "Developer", basicsalary) { }

        public override double CalculateCTC()
        {
            double total = CalculateMonthlySalary() * 12;
            return total;
        }

        public override double CalculateMonthlySalary()
        {
            double total = _basicsalary + Bonus + PerformaceAlloance;
            return total;
        }

        public double Bonus
        {
            get { return _basicsalary * BONUS; }
        }

        public double PerformaceAlloance
        {
            get { return _basicsalary * PA; }
        }

        public override string ToString()
        {
            return base.ToString()+"\nBonus:"+Bonus+"\nPA:"+PerformaceAlloance+"\nMonthly Salary:"+CalculateMonthlySalary()+
                "\nCTC:"+CalculateCTC();
        }
    }
}
