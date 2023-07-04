using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Contact
    {
        public string Name;
        public string PhoneNumber;
        public string Email;
        public string State;
        public string city;
    }

    class AddressBook
    {
        public List<Contact> contacts;
        public AddressBook()
        {
            contacts = new List<Contact>();
        }

        public void AddContact(Contact contact)
        {
            contacts.Add(contact);

            Console.WriteLine("Contact added successfully");
        }

        public void ViewContact()
        {
            foreach (Contact contact in contacts)
            {
                Console.WriteLine(contact.Name);
                Console.WriteLine(contact.PhoneNumber);
                Console.WriteLine(contact.Email);
            }
        }

        public void EditContact(string name)
        {
            foreach (Contact contact in contacts)
            {

                if (contact.Name == name)
                {
                    Console.WriteLine("Enter the changes");

                    Console.Write("Enter the new email :");
                    string newEmail = Console.ReadLine();

                    Console.Write("Enter the new PhoneNumber :");
                    string newPhone_number = Console.ReadLine();

                    contact.PhoneNumber = newPhone_number;
                    contact.Email = newEmail;
                }

                else if (contact.Name != name)
                {
                    Console.WriteLine("The contact doesn't exsit !");
                }
            }
        }

    }
    
}
