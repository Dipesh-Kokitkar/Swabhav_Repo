using System;

namespace SalarySlip
{
    abstract class Employee
    {
        private string _name, _dateofjoining, _designtion;
        private int _workwith;
        protected double _basicsalary;


        public Employee(string name, string dateofjoin, string designtion, double basicsalary)
        {
            _name = name;
            _dateofjoining = dateofjoin;
            _designtion = designtion;
            _basicsalary = basicsalary;

            
        }

        public abstract double CalculateCTC();
        public abstract double CalculateMonthlySalary();

        public string Name
        {
            get { return _name; }
        }

        public string DateOfJoining
        {
            get { return _dateofjoining; }
        }

        public string Designation
        {
            get { return _designtion; }
        }

        public double BasicSalary
        {
            get { return _basicsalary; }
        }

        public int GetYearOfExperiance() {
            string[] date = _dateofjoining.Split('-');
            DateTime enddate = DateTime.Now;
            _workwith = (enddate.Year - Convert.ToInt32(date[2]));
            return _workwith;
        }

        public override string ToString()
        {
            return "Name:" + Name + "\nDate of Joining:" + DateOfJoining + "\nDesignation:" + Designation 
                +"Year of Experiance in company:"+GetYearOfExperiance()+ "\nBasic Salary:"
                + BasicSalary;
        }
    }
}
