using System;

namespace LoanBuddy
{
    internal class LoanMain
    {
        public static void Main(string[] args)
        {
            LoanMenu menu = new LoanMenu();
            menu.Start();

            Console.ReadLine();
        }
    }
}
