using System;
using System.IO;

class CountRowsCSV
{
    static void Main()
    {
        string path = "employees.csv";
        int count = 0;

        try
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;

                reader.ReadLine(); // Skip header

                while ((line = reader.ReadLine()) != null)
                {
                    count++;
                }
            }

            Console.WriteLine($"Total Records (excluding header): {count}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
