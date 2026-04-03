using System;

// Base class
class Employee
{
    // Method to display employee information
    public virtual void DisplayDetails()
    {
        Console.WriteLine("This is an employee");
    }
}

// Manager class inherits Employee
class Manager : Employee
{
    // Overriding method
    public override void DisplayDetails()
    {
        Console.WriteLine("Manager manages a team");
    }
}

// Developer class inherits Employee
class Developer : Employee
{
    // Overriding method
    public override void DisplayDetails()
    {
        Console.WriteLine("Developer writes code");
    }
}

// Intern class inherits Employee
class Intern : Employee
{
    // Overriding method
    public override void DisplayDetails()
    {
        Console.WriteLine("Intern is learning");
    }
}

// Main class
class Program
{
    static void Main()
    {
        // Creating objects using parent class reference
        Employee emp1 = new Manager();
        Employee emp2 = new Developer();
        Employee emp3 = new Intern();

        // Calling same method for different objects
        emp1.DisplayDetails();
        emp2.DisplayDetails();
        emp3.DisplayDetails();
    }
}
