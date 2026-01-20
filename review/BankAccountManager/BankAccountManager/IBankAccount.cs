using System;

namespace BankAccountManager
{
    internal interface IBankAccount
    {
        void CreateAccount();
        void Deposit(double amount);
        void Withdraw(double amount);
        void CheckBalance();
    }
}
