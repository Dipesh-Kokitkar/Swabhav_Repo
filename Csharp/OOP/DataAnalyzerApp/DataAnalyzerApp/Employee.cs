using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAnalyzerApp
{
    class Employee
    {
        private readonly string _employeeid, _name, _designation;
        private readonly string _managerid, _dateofbirth, _salary;
        private readonly string _commission, _departmentnumber;

        public Employee(string[] attributes)
        {
            _employeeid = attributes[0];
            _name = attributes[1];
            _designation = attributes[2];
            _managerid = attributes[3];
            _dateofbirth = attributes[4];
            _salary = attributes[5];
            _commission = attributes[6];
            _departmentnumber = attributes[7];
        }

        public string EmployeeID
        {
            get { return _employeeid; }
        }
        public string Name
        {
            get { return _name; }
        }

        public string Designation
        {
            get { return _designation; }
        }

        public string ManagerID
        {
            get { return _managerid; }
        }

        public string DateOfBirth
        {
            get { return _dateofbirth; }
        }

        public string Salary
        {
            get { return _salary; }
        }

        public string Comission
        {
            get { return _commission; }
        }

        public string DepartmentNumber
        {
            get { return _departmentnumber; }
        }
    }
}
