using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern
{
    class Employee
    {
        private readonly String _name;
        private readonly String _department;
        private readonly int _salary;
        private List<Employee> _subordinates;

        public Employee(String name, String dept, int salary)
        {
            _name = name;
            _department = dept;
            _salary = salary;
            _subordinates = new List<Employee>();
        }

        public void Add(Employee e)
        {
            _subordinates.Add(e);
        }

        public void Remove(Employee e)
        {
            _subordinates.Remove(e);
        }

        public List<Employee> GetSubordinates()
        {
            return _subordinates;
        }

        public override string ToString()
        {
            return ("Employee :[ Name : " + _name + ", dept : " + _department + ", salary :" + _salary + " ]");
        }

    }
}
