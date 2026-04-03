using System;
using System.IO;
using System.Collections.Generic;

class UpdateSalaryCSV
{
    static void Main()
    {
        var lines = new List<string>();

        using (StreamReader reader = new StreamReader("employees.csv"))
        {
            string line;
            lines.Add(reader.ReadLine()); // header

            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split(',');

                if (data[2] == "IT")
                {
                    double salary = double.Parse(data[3]);
                    salary *= 1.10; // increase by 10%
                    data[3] = salary.ToString();
                }

                lines.Add(string.Join(",", data));
            }
        }

        File.WriteAllLines("updated_employees.csv", lines);
        Console.WriteLine("Updated file created!");
    }
}
