using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class SortBySalaryCSV
{
    static void Main()
    {
        var employees = new List<string[]>();

        using (StreamReader reader = new StreamReader("employees.csv"))
        {
            string line;
            reader.ReadLine(); // skip header

            while ((line = reader.ReadLine()) != null)
            {
                employees.Add(line.Split(','));
            }
        }

        var top5 = employees
            .OrderByDescending(e => double.Parse(e[3]))
            .Take(5);

        Console.WriteLine("Top 5 Highest Paid Employees:\n");

        foreach (var emp in top5)
        {
            Console.WriteLine($"{emp[1]} - Salary: {emp[3]}");
        }
    }
}
