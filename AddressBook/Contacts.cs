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

    }
    
}
