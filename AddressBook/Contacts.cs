using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Security.Cryptography.X509Certificates;

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
            Regex checkname = new Regex("^[A-Z][a-zA-Z]{2,}$");
            if (checkname.IsMatch(contact.Name))
            {
                contacts.Add(contact);
            }
            else
            {
                Console.WriteLine("Invalid Name format format");
                return;
            }

            Regex checkMob = new Regex("[1-9]{2}[ ][0-9]{10}");
            if (checkMob.IsMatch(contact.PhoneNumber))
            {
                contacts.Add(contact);
            }
            else
            {
                Console.WriteLine("Invalid Phone number format");
                return;
            }

            Regex checkemail = new Regex("[a-z]{3}.[a-z]{3}@[a-z]{2}.[a-z]{2}.[a-z]{2}");
            if (checkemail.IsMatch(contact.Email))
            {
                contacts.Add(contact);
            }
            else
            {
                Console.WriteLine("Invalid Email Format");
                return;
            }

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

        public void DisplayContact()
        {
            foreach (Contact contact in contacts)
            {
                Console.WriteLine(contact.Name);
            }
        }
        public void DeleteContact(string name)
        {

            foreach (Contact contact in contacts)
            {
                if (contact.Name == name)
                {
                    contacts.Remove(contact);
                    Console.WriteLine("Contact deleted successfully :");
                    DisplayContact();
                    return;

                }

            }
            Console.WriteLine("contact not found");
        }

    }
    
}
