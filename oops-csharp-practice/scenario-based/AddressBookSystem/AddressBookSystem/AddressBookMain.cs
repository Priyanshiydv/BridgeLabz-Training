using System;

namespace AddressBookSystem
{
    class AddressBookMain
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Address Book Program on Master Branch");
            Console.WriteLine("-----------------------------------------------");

            AddressBookMenu menu = new AddressBookMenu();
            menu.ShowMenu();
        }
    }
}
