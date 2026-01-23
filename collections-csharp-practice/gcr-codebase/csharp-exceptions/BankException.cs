using System;

class InsufficientFundsException : Exception
{
    public InsufficientFundsException(string message) : base(message) { }
}

class BankAccount
{
    double balance = 1000;

    public void Withdraw(double amount)
    {
        if (amount < 0)
            throw new ArgumentException("Invalid amount!");

        if (amount > balance)
            throw new InsufficientFundsException("Insufficient balance!");

        balance -= amount;
        Console.WriteLine("Withdrawal successful, new balance: " + balance);
    }
}

class BankException
{
    static void Main()
    {
        BankAccount account = new BankAccount();

        try
        {
            account.Withdraw(1500);
        }
        catch (InsufficientFundsException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
