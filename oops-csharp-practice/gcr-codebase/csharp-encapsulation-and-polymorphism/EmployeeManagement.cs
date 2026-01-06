using System;

// Interface for Department
interface IDepartment
{
    void AssignDepartment(string deptName);
    string GetDepartmentDetails();
}

// Abstract class Employee
abstract class Employee
{
    // Private fields (Encapsulation)
    private int employeeId;
    private string name;
    private double baseSalary;

    // Public properties
    public int EmployeeId
    {
        get { return employeeId; }
        set { employeeId = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double BaseSalary
    {
        get { return baseSalary; }
        set
        {
            if (value >= 0)
                baseSalary = value;
        }
    }

    // Constructor
    public Employee(int id, string name, double salary)
    {
        EmployeeId = id;
        Name = name;
        BaseSalary = salary;
    }

    // Abstract method
    public abstract double CalculateSalary();

    // Concrete method
    public void DisplayDetails()
    {
        Console.WriteLine("Employee ID : " + EmployeeId);
        Console.WriteLine("Name        : " + Name);
        Console.WriteLine("Salary      : " + CalculateSalary());
    }
}

// Full Time Employee
class FullTimeEmployee : Employee, IDepartment
{
    private string department;

    public FullTimeEmployee(int id, string name, double salary)
        : base(id, name, salary)
    {
    }

    public override double CalculateSalary()
    {
        return BaseSalary;
    }

    public void AssignDepartment(string deptName)
    {
        department = deptName;
    }

    public string GetDepartmentDetails()
    {
        return department;
    }
}

// Part Time Employee
class PartTimeEmployee : Employee, IDepartment
{
    private int hoursWorked;
    private double hourlyRate;
    private string department;

    public PartTimeEmployee(int id, string name, int hours, double rate)
        : base(id, name, 0)
    {
        hoursWorked = hours;
        hourlyRate = rate;
    }

    public override double CalculateSalary()
    {
        return hoursWorked * hourlyRate;
    }

    public void AssignDepartment(string deptName)
    {
        department = deptName;
    }

    public string GetDepartmentDetails()
    {
        return department;
    }
}

// Main Class
class EmployeeManagement
{
    static void Main()
    {
        // Employee array (Polymorphism)
        Employee[] employees = new Employee[2];

        FullTimeEmployee emp1 = new FullTimeEmployee(101, "Ritu", 40000);
        emp1.AssignDepartment("HR");

        PartTimeEmployee emp2 = new PartTimeEmployee(102, "Divya", 30, 500);
        emp2.AssignDepartment("IT");

        employees[0] = emp1;
        employees[1] = emp2;

       
        for (int i = 0; i < employees.Length; i++)
        {
            employees[i].DisplayDetails();
            Console.WriteLine("-----------------------");
        }
    }
}
