using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountManager
{

    sealed class BankMenu
    {
        private IBankAccount bank;

        public void Start()
        {
            bank = new BankAccountUtilityImpl();
            int choice;
            double amount;

            do
            {
                Console.WriteLine("\n- Bank Account Menu -");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Check Balance");
                Console.WriteLine("0. Exit");

                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        bank.CreateAccount();
                        break;

                    case 2:
                        Console.Write("Enter deposit amount: ");
                        amount = Convert.ToDouble(Console.ReadLine());
                        bank.Deposit(amount);
                        break;

                    case 3:
                        Console.Write("Enter withdraw amount: ");
                        amount = Convert.ToDouble(Console.ReadLine());
                        bank.Withdraw(amount);
                        break;

                    case 4:
                        bank.CheckBalance();
                        break;

                    case 0:
                        Console.WriteLine("Exiting Banking App...");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }

            } while (choice != 0);
        }
    }
}

