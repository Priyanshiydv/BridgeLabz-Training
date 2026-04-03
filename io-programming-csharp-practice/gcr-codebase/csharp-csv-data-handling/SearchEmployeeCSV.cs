using System;
using System.IO;

class SearchEmployeeCSV
{
    static void Main()
    {
        Console.Write("Enter employee name: ");
        string searchName = Console.ReadLine();

        using (StreamReader reader = new StreamReader("employees.csv"))
        {
            string line;
            reader.ReadLine(); // skip header

            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split(',');

                if (data[1].Equals(searchName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Department: {data[2]}");
                    Console.WriteLine($"Salary: {data[3]}");
                    return;
                }
            }

            Console.WriteLine("Employee not found.");
        }
    }
}
