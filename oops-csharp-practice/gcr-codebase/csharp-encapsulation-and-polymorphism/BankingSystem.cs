using System;

abstract class BankAccount
{
    private double balance;

    public BankAccount(double bal)
    {
        balance = bal;
    }

    public void Deposit(double amount)
    {
        balance = balance + amount;
    }

    public abstract double CalculateInterest();

    public double GetBalance()
    {
        return balance;
    }
}

class SavingsAccount : BankAccount
{
    public SavingsAccount(double bal) : base(bal) { }

    public override double CalculateInterest()
    {
        return GetBalance() * 0.04;
    }
}

class Program
{
    static void Main()
    {
        BankAccount[] acc = new BankAccount[1];
        acc[0] = new SavingsAccount(10000);

        for (int i = 0; i < acc.Length; i++)
            Console.WriteLine(acc[i].CalculateInterest());
    }
}
