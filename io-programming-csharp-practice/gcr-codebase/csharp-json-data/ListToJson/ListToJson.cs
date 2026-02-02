using System;
using System.Collections.Generic;
using System.Text.Json;

// Employee class
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Department { get; set; } = "";
    public double Salary { get; set; }
}

class ListToJson
{
    static void Main()
    {
        // Create list of employees
        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Priya", Department = "IT", Salary = 50000 },
            new Employee { Id = 2, Name = "Rahul", Department = "HR", Salary = 45000 },
            new Employee { Id = 3, Name = "Anita", Department = "Finance", Salary = 55000 }
        };

        // Convert list to JSON array
        string jsonArray = JsonSerializer.Serialize(employees, new JsonSerializerOptions { WriteIndented = true });

        Console.WriteLine("Employees JSON Array:");
        Console.WriteLine(jsonArray);
    }
}
