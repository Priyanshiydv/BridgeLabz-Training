using System;

public class EmployeeDetails
{
    private string name;
    private int id;
    private double salary;

    // Constructor to initialize employee details
    public EmployeeDetails(string name, int id, double salary)
    {
        this.name = name;
        this.id = id;
        this.salary = salary;
    }

    // Method to display employee details
    public void DisplayDetails()
    {
        Console.WriteLine("Employee Name: " + name);
        Console.WriteLine("Employee ID: " + id);
        Console.WriteLine("Salary: " + salary);
    }
}

public class Program
{
    public static void Main()
    {
        // Creating Employee object
        EmployeeDetails emp = new EmployeeDetails("Priyanshi", 01, 55000);

        // Displaying details
        emp.DisplayDetails();
    }
}
