using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

// Employee class (like DB table)
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }
}

class JsonReport
{
    static void Main()
    {
        // Simulated database records
        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Amit", Department = "IT", Salary = 55000 },
            new Employee { Id = 2, Name = "Neha", Department = "HR", Salary = 48000 },
            new Employee { Id = 3, Name = "Ravi", Department = "Finance", Salary = 62000 }
        };

        // Convert to JSON
        string jsonReport = JsonConvert.SerializeObject(employees, Formatting.Indented);

        // Save to file (like report)
        File.WriteAllText("EmployeeReport.json", jsonReport);

        Console.WriteLine("JSON Report Generated Successfully!\n");
        Console.WriteLine(jsonReport);
    }
}
