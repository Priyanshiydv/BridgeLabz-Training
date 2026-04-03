using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

class JsonCsvConverter
{
    static void Main()
    {
        // JSON → CSV
        var students = JsonSerializer.Deserialize<List<Student>>(File.ReadAllText("students.json"));

        using (StreamWriter writer = new StreamWriter("students.csv"))
        {
            writer.WriteLine("ID,Name,Age,Marks");
            foreach (var s in students)
                writer.WriteLine($"{s.ID},{s.Name},{s.Age},{s.Marks}");
        }

        // CSV → JSON
        var list = new List<Student>();
        using (StreamReader reader = new StreamReader("students.csv"))
        {
            reader.ReadLine();
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                string[] d = line.Split(',');
                list.Add(new Student { ID = int.Parse(d[0]), Name = d[1], Age = int.Parse(d[2]), Marks = int.Parse(d[3]) });
            }
        }

        File.WriteAllText("output.json", JsonSerializer.Serialize(list, new JsonSerializerOptions { WriteIndented = true }));
    }
}

class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }
}
