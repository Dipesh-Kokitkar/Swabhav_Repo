using System;
using System.Collections.Generic;

namespace DataAnalyzerApp
{
    class EqualityCheck : IEqualityComparer<Employee>
    {
        public bool Equals(Employee x, Employee y)
        {
            if (x.EmployeeID == y.EmployeeID)
                return true;
            return false;
        }

        public int GetHashCode(Employee obj)
        {
            return obj.EmployeeID.GetHashCode();
        }
    }
}
