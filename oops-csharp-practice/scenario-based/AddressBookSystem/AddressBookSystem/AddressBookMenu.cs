using System;

namespace AddressBookSystem
{
    class AddressBookMenu
    {
        private AddressBookSystemManager systemManager = new AddressBookSystemManager();

        //private AddressBookUtility utility = new AddressBookUtility();
        private Dictionary<string, AddressBookUtility> addressBooks =
    new Dictionary<string, AddressBookUtility>(); //UC6


        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\nAddress Book Menu");
                Console.WriteLine("1. Create Address Book");//UC6
                Console.WriteLine("2. Add Contact"); //UC2
                Console.WriteLine("3. View Contacts");
                Console.WriteLine("4. Edit Contact"); //UC3
                Console.WriteLine("5. Delete Contact"); //UC4
                
                Console.WriteLine("6. Search Person by City or State"); //UC8
                Console.WriteLine("7. View Persons by City or State"); //UC9
                Console.WriteLine("8. Count Contacts by City or State"); //UC10
                Console.WriteLine("9. Sort Contacts by Name"); //UC11
                Console.WriteLine("10. Sort Contacts by Location"); // UC12
                Console.WriteLine("11. Exit");



                Console.WriteLine("Enter your choice:");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        systemManager.CreateAddressBook();  //UC6
                        break;
                    case "2":
                        var book1 = systemManager.SelectAddressBook();
                        if (book1 != null) book1.AddContact();
                        break;

                    case "3":
                        var book2 = systemManager.SelectAddressBook();
                        if (book2 != null) book2.ViewContacts();
                        break;

                    case "4":
                        var book3 = systemManager.SelectAddressBook();
                        if (book3 != null) book3.EditContact();
                        break;

                    case "5":
                        var book4 = systemManager.SelectAddressBook();
                        if (book4 != null) book4.DeleteContact();
                        break;

                    case "6":
                        systemManager.SearchPersonByCityOrState();
                        break;
                    case "7":
                        systemManager.ViewPersonsByCityOrState();
                        break;
                    case "8":
                        systemManager.CountContactsByCityOrState();
                        break;
                    case "9":
                        var book = systemManager.SelectAddressBook();
                        if (book != null)
                            book.SortContactsByName();
                        break;
                    case "10":
                        var book8 = systemManager.SelectAddressBook();
                        if (book8 != null)
                        book8.SortContactsByLocation();
                        break;
                    case "11":
                        break;

                    default:
                        Console.WriteLine("Invalid Choice.");
                        break;
                }
            }
        }
    }
}
       