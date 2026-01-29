using System;
using System.IO;
using System.Collections.Generic;

class CSVToStudentObjects
{
    static void Main()
    {
        List<Student> students = new List<Student>();

        using (StreamReader reader = new StreamReader("students.csv"))
        {
            string line;
            reader.ReadLine(); // skip header

            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split(',');

                Student s = new Student
                {
                    ID = int.Parse(data[0]),
                    Name = data[1],
                    Age = int.Parse(data[2]),
                    Marks = int.Parse(data[3])
                };

                students.Add(s);
            }
        }

        foreach (var s in students)
            Console.WriteLine($"{s.Name} - {s.Marks}");
    }
}

class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }
}
