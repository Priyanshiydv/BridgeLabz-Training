using System;
using System.IO;

class FilterStudentsCSV
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader("students.csv"))
        {
            string line;
            reader.ReadLine(); // skip header

            Console.WriteLine("Students with Marks > 80:\n");

            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split(',');
                int marks = int.Parse(data[3]);

                if (marks > 80)
                {
                    Console.WriteLine($"{data[1]} - {marks}");
                }
            }
        }
    }
}
