using System;

namespace SalarySlip
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager ram = new Manager("Ram", "06-June-2015", 35000);
            Developer ramesh = new Developer("Remesh", "17-feb-2018", 30000);
            Accountant ashwini = new Accountant("Ashwini", "1-May-2017", 15000);

            //ShowSalarySlip(ram);
            //ShowSalarySlip(ramesh);
            //ShowSalarySlip(ashwini);
            PrintSalarySlip(ram);
            PrintSalarySlip(ramesh);
            PrintSalarySlip(ashwini);



        }

        static void PrintSalarySlip(Employee employee) {
            Console.WriteLine("\n\tSalary Silp");
            Console.WriteLine();
            Console.WriteLine(employee.ToString());
        }

        static void ShowSalarySlip(Employee employee)
        {
            Console.WriteLine("\n\tSalary Silp");
            Console.WriteLine("Name:" + employee.Name + "\nDate Of Joining:" + employee.DateOfJoining + "\nDesignation:"
                + employee.Designation);
            Console.WriteLine("Basic Salary:" + employee.BasicSalary);
            Type type = employee.GetType();
            ShowAlloances(type, employee);
            Console.WriteLine("Monthy Salary:" + employee.CalculateMonthlySalary());
            Console.WriteLine("CTC:" + employee.CalculateCTC());

        }

        static void ShowAlloances(Type type, Employee employee)
        {

            if (employee is Manager)
            {
                Manager manager = (Manager)employee;
                Console.WriteLine("DA:" + manager.DearnessAlloance);
                Console.WriteLine("HRA:" + manager.HouseAndRentAlloance);
                Console.WriteLine("TA:" + manager.TravellingAlloance);
            }
            if (type.Name == "Developer")
            {
                Developer developer = (Developer)employee;
                Console.WriteLine("Bonus:" + developer.Bonus);
                Console.WriteLine("PA:" + developer.PerformaceAlloance);
            }
            if (type.Name == "Accountant")
            {
                Accountant accountant = (Accountant)employee;
                Console.WriteLine("Perks:" + accountant.Perks);
            }
        }


    }
}
