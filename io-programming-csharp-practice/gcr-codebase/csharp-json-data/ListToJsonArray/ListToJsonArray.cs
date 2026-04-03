using System;
using System.Collections.Generic;
using System.Text.Json;

// Student class
public class Student
{
    public string Name { get; set; } = "";
    public int Age { get; set; }
    public List<string> Subjects { get; set; } = new List<string>();
}

class ListToJsonArray
{
    static void Main()
    {
        // Create list of students
        List<Student> students = new List<Student>
        {
            new Student
            {
                Name = "Priya",
                Age = 22,
                Subjects = new List<string> { "Math", "Physics" }
            },
            new Student
            {
                Name = "Rahul",
                Age = 25,
                Subjects = new List<string> { "Chemistry", "Biology" }
            },
            new Student
            {
                Name = "Anita",
                Age = 23,
                Subjects = new List<string> { "Computer Science", "Math" }
            }
        };

        // Convert list to JSON array
        string jsonArray = JsonSerializer.Serialize(students, new JsonSerializerOptions { WriteIndented = true });

        Console.WriteLine("Students JSON Array:");
        Console.WriteLine(jsonArray);
    }
}
