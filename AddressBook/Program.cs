using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddressBook addressBook = new AddressBook();

            while (true)
            {
                Console.WriteLine("Address Book :");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. View Contacts");
                Console.WriteLine("3. Edit Contact");
                Console.WriteLine("4. Display Contact");
                Console.WriteLine("5. Delete Contact");
                Console.WriteLine("6. exit");


                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:

                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Phone Number: ");
                        string phone_Number = Console.ReadLine();
                        Console.Write("Enter Email: ");
                        string email = Console.ReadLine();
                        Console.Write("Enter the state");
                        string state = Console.ReadLine();
                        Console.Write("Enter the city");
                        string city = Console.ReadLine();

                        Contact newcontacts = new Contact();
                        newcontacts.Name = name;
                        newcontacts.PhoneNumber = phone_Number;
                        newcontacts.Email = email;
                        newcontacts.State = state;
                        newcontacts.city = city;

                        addressBook.AddContact(newcontacts);
                        Console.WriteLine();
                        break;

                    case 2:

                        addressBook.ViewContact();
                        Console.WriteLine();
                        break;

                    case 3:

                        Console.WriteLine("Enter the name of contact to edit :");
                        string contactname = Console.ReadLine();
                        addressBook.EditContact(contactname);
                        Console.WriteLine();
                        break;

                    case 4:

                        Console.WriteLine("Displaying all contact");
                        addressBook.DisplayContact();
                        break;

                    case 5:

                        Console.WriteLine("Enter the name to delete ");
                        string nametodelte = Console.ReadLine();
                        addressBook.DeleteContact(nametodelte);
                        break;

                }
            }

        }
    }
}
