using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankingAppLib;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //RegistrationTest();
            LoginTest();
        }

        private static void LoginTest() {
            string name, pwd;
            Login login = new Login();

            Console.WriteLine("Name:");
            name= Console.ReadLine();
            Console.WriteLine("pwd");
            pwd = Console.ReadLine();

            if (login.ValidateUser(name, pwd))
            {
                Console.WriteLine("sucess");
            }
            else {
                Console.WriteLine("Fail");
            }
        }

        private static void RegistrationTest()
        {
            string name, pwd;
            double amt;
            Registration res = new Registration();

            Console.WriteLine("Name:");
            name = Console.ReadLine();
            Console.WriteLine("password:");
            pwd = Console.ReadLine();
            Console.WriteLine("amount:");
            amt = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Res:" + res.RegistorNewAccount(name, pwd, amt));
        }
    }
}
