using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Current account1 = new Current(1001,"ABC",2000);
            Savings account2 = new Savings(1002,"XYZ",500);

            ShowAccountInformation(account1);
            ShowAccountInformation(account2);

            account1.Withdraw(3000);
            try
            {
                account2.Withdraw(200);
            }
            catch (Exception e) {
                Console.WriteLine("\nMessage:"+e.Message);
            }

            ShowAccountInformation(account1);
            ShowAccountInformation(account2);
        }

        static void ShowAccountInformation(Account account) {
            Console.WriteLine("\tAccount Infomation");
            Console.WriteLine("\nAccount No:" + account.AccounNumber+"\nName:"+account.Name+"\nAccount Type:"+account.Type+
                "\nBalance Amount:"+account.Balance);
        }
    }
}
