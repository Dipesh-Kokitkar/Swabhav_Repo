using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMTPMailApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter receiver email id : ");
            string receiverMail = Console.ReadLine();
            Console.WriteLine("Enter your Message");
            string message = Console.ReadLine();
            Mail email = new Mail();
            email.SendMail(receiverMail,message);
            Console.WriteLine("Email sent Successfully");
        }
    }
}
