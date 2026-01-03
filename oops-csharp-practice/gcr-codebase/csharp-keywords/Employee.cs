using System;

class Employee
{
    public static string CompanyName = "Tech Solutions";
    private static int totalEmployees = 0;

    public readonly int Id;
    public string Name;
    public string Designation;

    public Employee(string name, int id, string designation)
    {
        this.Name = name;
        this.Id = id;
        this.Designation = designation;
        totalEmployees++;
    }

    public static void DisplayTotalEmployees()
    {
        Console.WriteLine("Total Employees: " + totalEmployees);
    }

    public void Display()
    {
        Console.WriteLine("Company: " + CompanyName);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("ID: " + Id);
        Console.WriteLine("Designation: " + Designation);
    }
}

class Program
{
    static void Main()
    {
        Employee e1 = new Employee("Anita", 201, "Developer");

        if (e1 is Employee)
        {
            e1.Display();
        }

        Employee.DisplayTotalEmployees();
    }
}
