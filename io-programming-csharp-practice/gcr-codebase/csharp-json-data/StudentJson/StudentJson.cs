using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Student class
public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public List<string> Subjects { get; set; }
}

class StudentJson
{
    static void Main()
    {
        // Create student object
        Student student = new Student();
        student.Name = "Priyanshi";
        student.Age = 22;
        student.Subjects = new List<string>();
        student.Subjects.Add("Math");
        student.Subjects.Add("Physics");
        student.Subjects.Add("Computer");

        // Convert to JSON
        string json = JsonConvert.SerializeObject(student, Formatting.Indented);

        Console.WriteLine("Student JSON:");
        Console.WriteLine(json);
    }
}
