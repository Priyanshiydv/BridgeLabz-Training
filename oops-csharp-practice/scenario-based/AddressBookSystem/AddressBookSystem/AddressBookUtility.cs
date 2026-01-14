using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    class AddressBookUtility
    {
        private List<Contact> contacts = new List<Contact>();

        // UC-2 Add New Contact (Console input)
        public void AddContact()
        {
            Console.WriteLine("Enter First Name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter Address:");
            string address = Console.ReadLine();

            Console.WriteLine("Enter City:");
            string city = Console.ReadLine();

            Console.WriteLine("Enter State:");
            string state = Console.ReadLine();

            Console.WriteLine("Enter Zip:");
            string zip = Console.ReadLine();

            Console.WriteLine("Enter Phone Number:");
            string phone = Console.ReadLine();

            Console.WriteLine("Enter Email:");
            string email = Console.ReadLine();

            // Create Contact object (composition)
            Contact contact = new Contact()
            {
                FirstName = firstName,
                LastName = lastName,
                Address = address,
                City = city,
                State = state,
                Zip = zip,
                PhoneNumber = phone,
                Email = email
            };

            contacts.Add(contact);

            Console.WriteLine("New Contact Added Successfully!");
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
        // UC-3: Edit existing contact
        public void EditContact()
        {
            Console.WriteLine("Enter First Name of contact to edit:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name of contact to edit:");
            string lastName = Console.ReadLine();

            Contact found = null;

            
            for (int i = 0; i < contacts.Count; i++)
            {
                if (contacts[i].FirstName == firstName && contacts[i].LastName == lastName)
                {
                    found = contacts[i];
                    break;
                }
            }

            if (found == null)
            {
                Console.WriteLine("Contact not found.");
                return;
            }

            // Update details
            Console.WriteLine("Editing contact. Press Enter to keep existing value.");

            Console.WriteLine("Current Address: " + found.Address);
            Console.WriteLine("Enter New Address:");
            string address = Console.ReadLine();
            if (address != "") found.Address = address;

            Console.WriteLine("Current City: " + found.City);
            Console.WriteLine("Enter New City:");
            string city = Console.ReadLine();
            if (city != "") found.City = city;

            Console.WriteLine("Current State: " + found.State);
            Console.WriteLine("Enter New State:");
            string state = Console.ReadLine();
            if (state != "") found.State = state;

            Console.WriteLine("Current Zip: " + found.Zip);
            Console.WriteLine("Enter New Zip:");
            string zip = Console.ReadLine();
            if (zip != "") found.Zip = zip;

            Console.WriteLine("Current Phone: " + found.PhoneNumber);
            Console.WriteLine("Enter New Phone:");
            string phone = Console.ReadLine();
            if (phone != "") found.PhoneNumber = phone;

            Console.WriteLine("Current Email: " + found.Email);
            Console.WriteLine("Enter New Email:");
            string email = Console.ReadLine();
            if (email != "") found.Email = email;

            Console.WriteLine("Contact Updated Successfully!");
        }

    }
}
      