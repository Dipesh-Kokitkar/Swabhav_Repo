using System;
using AccountApp.Business;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializtionApp
{
    class Program
    {
        static void AccountInfo(Account account) {
            Console.WriteLine("Account No:"+account.Accountno+"\nName:"+account.Name+"\nBalance:"+account.Balance);
        }

         static void SerializeObject(Account account) {
           
            //Stream stream = File.Create("Account.dat");
            BinaryFormatter binaryformatter = new BinaryFormatter();
            FileStream fileout = new FileStream("AccountInfo.binary",FileMode.Create,FileAccess.Write,FileShare.None);
            try
            {
                using (fileout)
                {
                    binaryformatter.Serialize(fileout, account);
                    Console.WriteLine("Serializtion sucessful!");
                }
            }
            catch (Exception e) {
                Console.WriteLine("Error Message:"+e.Message);
            }

        }

        static Account DeserializeObject() {
            BinaryFormatter binaryformatter = new BinaryFormatter();
            FileStream filein = new FileStream("AccountInfo.binary", FileMode.Open,FileAccess.Read);
            try
            {
                using (filein)
                {
                    return (Account)binaryformatter.Deserialize(filein);
                }
            }
            catch (Exception e) {
                Console.WriteLine("Error Message:"+e.Message);
            }
            return null;
        }

        static void Main(string[] args)
        {
            Account account1 = new Account(123,"ABC",5000);
            AccountInfo(account1);

            SerializeObject(account1);

            account1.Deposit(500);
            AccountInfo(account1);

            Console.WriteLine("After deserialization object state:");
            Account account2= DeserializeObject();

            AccountInfo(account2);
        }
    }
}
