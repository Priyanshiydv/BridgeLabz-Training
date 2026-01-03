using System;
using System.Collections.Generic;

class Customer
{
    public string Name;
    public double Balance;

    public Customer(string name)
    {
        Name = name;
        Balance = 0;
    }

    public void ViewBalance()
    {
        Console.WriteLine($"{Name}'s Balance: {Balance}");
    }
}

class Bank
{
    public string BankName;
    public List<Customer> Customers = new List<Customer>();

    public Bank(string name)
    {
        BankName = name;
    }

    public void OpenAccount(Customer customer, double amount)
    {
        customer.Balance = amount;
        Customers.Add(customer);
        Console.WriteLine($"Account opened for {customer.Name} in {BankName}");
    }
}

class BankAccount
{
    static void Main()
    {
        Bank bank = new Bank("State Bank");
        Customer c1 = new Customer("Divya");

        bank.OpenAccount(c1, 5000);
        c1.ViewBalance();
    }
}
