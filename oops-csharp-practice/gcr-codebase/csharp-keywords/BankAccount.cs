using System;
//01-01-2026
class BankAccount
{
    // static variable
    public static string bankName = "State Bank of India";
    private static int totalAccounts = 0;

    // readonly variable
    public readonly int AccountNumber;

    // instance variable
    public string AccountHolderName;

    // constructor using this
    public BankAccount(string accountHolderName, int accountNumber)
    {
        this.AccountHolderName = accountHolderName;
        this.AccountNumber = accountNumber;
        totalAccounts++;
    }

    // static method
    public static void GetTotalAccounts()
    {
        Console.WriteLine("Total Accounts: " + totalAccounts);
    }

    public void Display()
    {
        Console.WriteLine("Bank Name: " + bankName);
        Console.WriteLine("Account Holder: " + AccountHolderName);
        Console.WriteLine("Account Number: " + AccountNumber);
    }
}

class Program
{
    static void Main()
    {
        BankAccount acc1 = new BankAccount("Priyanshi", 101);

        // is operator
        if (acc1 is BankAccount)
        {
            acc1.Display();
        }

        BankAccount.GetTotalAccounts();
    }
}
