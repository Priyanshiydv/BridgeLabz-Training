using System;

class BankAccount
{
    public string accountNumber;
    protected string accountHolder;
    private int balance;

    public void Deposit(int amount)
    {
        balance = balance + amount;
    }

    public int GetBalance()
    {
        return balance;
    }
}

class SavingsAccount : BankAccount
{
    static void Main()
    {
        SavingsAccount s = new SavingsAccount();
        s.accountNumber = "ACC01";
        s.accountHolder = "Priyanshi";
        s.Deposit(5000);

        Console.WriteLine("Account: " + s.accountNumber);
        Console.WriteLine("Holder: " + s.accountHolder);
        Console.WriteLine("Balance: " + s.GetBalance());
    }
}
