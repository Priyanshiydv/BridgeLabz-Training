using System;

namespace BankAccountManager
{
    internal class BankAccountUtilityImpl : IBankAccount
    {
        private BankAccount account = new BankAccount();

        //create account
        public void CreateAccount()
        {
            Console.Write("Enter Account Number: ");
            account.AccountNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Initial Balance: ");
            account.Balance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nAccount Created Successfully!");
            Console.WriteLine(account.ToString());
        }

        //deposit
        public void Deposit(double amount)
        {
            account.Balance = account.Balance + amount;
            Console.WriteLine("Amount Deposited:" + amount);
        }

        //withdraw
        public void Withdraw(double amount)
        {
            if (amount > account.Balance)
            {
                Console.WriteLine("Insufficient Balance! Withdrawal not allowed.");
            }
            else
            {
                account.Balance = account.Balance - amount;
                Console.WriteLine("Amount Withdrawn:" + amount);
            }
        }

        //check balance
        public void CheckBalance()
        {
            Console.WriteLine("Current Balance: " + account.Balance);
        }
    }
}

