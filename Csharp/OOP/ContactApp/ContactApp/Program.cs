using System;
using System.Collections;

namespace ContactApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ContactManager contactmanager = new ContactManager();
            do
            {
                Console.WriteLine("\tContact App");
                Console.WriteLine("1.Add new Contact\n2.Display Contact List\n3.Exit");
                Console.WriteLine("Enter your Choice:");
                int ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        AddNewConatct(contactmanager);
                        Console.WriteLine("New Contact Sucessfully added!\n");
                        break;
                    case 2:
                        ArrayList newlist = contactmanager.ShowConatctList();
                        foreach (Contact contact in newlist)
                        {
                            ShowContactInformation(contact);
                        }
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                }
            } while (true);

        }

        static void ShowContactInformation(Contact contact)
        {
            Console.WriteLine("\n\tInformation");
            Console.WriteLine("Name:" + contact.Name + "\nPhone No:" + contact.PhoneNumber +
                "\nEmail:" + contact.Email + "\nAddress:" + contact.Address);
            Console.WriteLine();
        }

        static void AddNewConatct(ContactManager contactmanager)
        {
            Console.WriteLine("Enter name,Phone number,Email and Address:");
            string name = Console.ReadLine();
            double phonenumber = Convert.ToDouble(Console.ReadLine());
            string email = Console.ReadLine();
            string address = Console.ReadLine();
            contactmanager.AddNewContact(name, phonenumber, email, address);
        }
    }
}
