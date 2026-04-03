using System;
using System.IO;

class ReadErrorLines
{
    static void Main()
    {
        
        string fileName = "log.txt";

        try
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                string line;

                while ((line = sr.ReadLine()) != null) // Read line by line
                {
                    // Print only lines containing "error" (case-insensitive)
                    if (line.IndexOf("error", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading the file: " + ex.Message);
        }
    }
}
