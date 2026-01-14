using System;

namespace AddressBookSystem
{
    class AddressBookMenu
    {
        private AddressBookUtility utility = new AddressBookUtility();

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\nAddress Book Menu");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. View Contacts");
                Console.WriteLine("3. Edit Contact"); //UC3
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice:");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        utility.AddContact();
                        break;
                    case "2":
                        utility.ViewContacts();
                        break;
                    case "3":
                        utility.EditContact();
                        break;
                    case "4":
                        Console.WriteLine("Exiting Address Book...");
                        return;
                    default:
                        Console.WriteLine("Invalid Choice. Try Again.");
                        break;
                }
            }
        }
    }
}
