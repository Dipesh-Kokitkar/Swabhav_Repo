using System;

namespace SalarySlip
{
    class Manager : Employee
    {
        private const double HRA = 0.5;
        private const double TA = 0.4;
        private const double DA = 0.3;

        public Manager(string name, string dateofjoin, double basicsalary)
            : base(name, dateofjoin, "Manager", basicsalary) { }

        public override double CalculateCTC()
        {
            double total = CalculateMonthlySalary() * 12;
            return total;
        }

        public override double CalculateMonthlySalary()
        {
            double total = _basicsalary + DearnessAlloance + TravellingAlloance + HouseAndRentAlloance;
            return total;
        }

        public double DearnessAlloance
        {
            get { return _basicsalary * DA; }
        }

        public double TravellingAlloance
        {
            get { return _basicsalary * TA; }
        }

        public double HouseAndRentAlloance
        {
            get { return _basicsalary * HRA; }
        }

        public override string ToString()
        {
            return base.ToString()+"\nDA:" + DearnessAlloance + "\nTA:" + TravellingAlloance + "\nHRA:" + HouseAndRentAlloance +
                "\nMonthly Salary:" + CalculateMonthlySalary() + "\nCTC:" + CalculateCTC();
        }
    }
}
