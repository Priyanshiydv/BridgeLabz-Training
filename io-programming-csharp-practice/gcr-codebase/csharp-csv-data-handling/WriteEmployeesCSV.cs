using System;
using System.IO;

class WriteEmployeesCSV
{
    static void Main()
    {
        string path = "employees.csv";

        try
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                // Header
                writer.WriteLine("ID,Name,Department,Salary");

                // 5 Records
                writer.WriteLine("101,Rahul,Engineering,60000");
                writer.WriteLine("102,Anita,HR,50000");
                writer.WriteLine("103,Sam,Marketing,55000");
                writer.WriteLine("104,Neha,Finance,62000");
                writer.WriteLine("105,Arjun,Sales,58000");
            }

            Console.WriteLine("Employee CSV file created successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
