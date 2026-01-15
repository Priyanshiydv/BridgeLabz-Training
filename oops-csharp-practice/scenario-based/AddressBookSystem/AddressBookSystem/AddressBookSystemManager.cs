using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    class AddressBookSystemManager
    {
        public Dictionary<string, AddressBookUtility> addressBooks = new Dictionary<string, AddressBookUtility>();

        public void CreateAddressBook()
        {
            Console.WriteLine("Enter Address Book Name:");
            string name = Console.ReadLine();

            if (addressBooks.ContainsKey(name))
            {
                Console.WriteLine("Address Book with this name already exists.");
                return;
            }

            addressBooks[name] = new AddressBookUtility();
            Console.WriteLine("Address Book Created Successfully!");
        }

        public AddressBookUtility SelectAddressBook()
        {
            Console.WriteLine("Enter Address Book Name:");
            string name = Console.ReadLine();

            if (addressBooks.ContainsKey(name))
                return addressBooks[name];
            else
            {
                Console.WriteLine("Address Book not found!");
                return null;
            }
        }

        // UC8: Search by City/State across all address books
        public void SearchPersonByCityOrState()
        {
            Console.WriteLine("Search by:");
            Console.WriteLine("1. City");
            Console.WriteLine("2. State");
            string option = Console.ReadLine();

            Console.WriteLine("Enter City or State name:");
            string searchValue = Console.ReadLine();

            bool found = false;

            // convert dictionary to list so we can use index-based for loop
            List<AddressBookUtility> bookList = new List<AddressBookUtility>(addressBooks.Values);

            for (int i = 0; i < bookList.Count; i++)
            {
                List<Contact> contacts = bookList[i].GetContacts();

                for (int j = 0; j < contacts.Count; j++)
                {
                    if (option == "1" &&
                        contacts[j].City.Equals(searchValue, StringComparison.OrdinalIgnoreCase))
                    {
                        contacts[j].Display();
                        found = true;
                    }
                    else if (option == "2" &&
                             contacts[j].State.Equals(searchValue, StringComparison.OrdinalIgnoreCase))
                    {
                        contacts[j].Display();
                        found = true;
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("No person found in given City/State.");
            }
        }
    }
}