using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    class AddressBookUtility
    {
        private List<Contact> contacts = new List<Contact>();

        public void AddContact()
        {
            Contact contact = new Contact();

            Console.WriteLine("Enter First Name:");
            contact.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name:");
            contact.LastName = Console.ReadLine();

            Console.WriteLine("Enter Address:");
            contact.Address = Console.ReadLine();

            Console.WriteLine("Enter City:");
            contact.City = Console.ReadLine();

            Console.WriteLine("Enter State:");
            contact.State = Console.ReadLine();

            Console.WriteLine("Enter Zip:");
            contact.Zip = Console.ReadLine();

            Console.WriteLine("Enter Phone Number:");
            contact.PhoneNumber = Console.ReadLine();

            Console.WriteLine("Enter Email:");
            contact.Email = Console.ReadLine();

            contacts.Add(contact);

            Console.WriteLine("Contact Added Successfully!");
        }

        public void ViewContacts()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("No contacts found.");
                return;
            }

            Console.WriteLine("All Contacts:");
            foreach (Contact contact in contacts)
            {
                contact.Display();
            }
        }
    }
}
