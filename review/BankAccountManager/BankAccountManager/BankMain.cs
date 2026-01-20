using System;

namespace BankAccountManager
{
    internal class BankMain
    {
        static void Main(string[] args)
        {
            BankMenu menu = new BankMenu();
            menu.Start();
        }
    }
}
