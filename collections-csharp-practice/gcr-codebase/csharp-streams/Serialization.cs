using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; } = "";        // avoid null warning
    public string Department { get; set; } = "";  // avoid null warning
    public double Salary { get; set; }
}

class Serialization
{
    static void Main()
    {
        string filePath = "employees.json";

        // Create employee list
        List<Employee> employees = new List<Employee>();
        employees.Add(new Employee { Id = 1, Name = "Amit", Department = "IT", Salary = 50000 });
        employees.Add(new Employee { Id = 2, Name = "Neha", Department = "HR", Salary = 45000 });

        // Enable reflection-based JSON serialization explicitly
        JsonSerializerOptions options = new JsonSerializerOptions();
        options.WriteIndented = true;
        options.TypeInfoResolver = new DefaultJsonTypeInfoResolver();

        try
        {
            // Serialize (Save)
            string jsonData = JsonSerializer.Serialize(employees, options);
            File.WriteAllText(filePath, jsonData);
            Console.WriteLine("Employees saved to file.");

            // Deserialize (Read)
            string readData = File.ReadAllText(filePath);
            List<Employee>? result =
                JsonSerializer.Deserialize<List<Employee>>(readData, options);

            Console.WriteLine("\nEmployees read from file:");
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(
                    result[i].Id + " " +
                    result[i].Name + " " +
                    result[i].Department + " " +
                    result[i].Salary
                );
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}
