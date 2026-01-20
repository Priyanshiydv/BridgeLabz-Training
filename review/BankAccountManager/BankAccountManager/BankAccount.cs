using System;

namespace BankAccountManager
{
    internal class BankAccount
    {
        public int AccountNumber { get; set; }
        public double Balance { get; set; }

        public override string ToString()
        {
            return "Account Number: " + AccountNumber +
                   "\nBalance: ₹" + Balance;
        }
    }
}
