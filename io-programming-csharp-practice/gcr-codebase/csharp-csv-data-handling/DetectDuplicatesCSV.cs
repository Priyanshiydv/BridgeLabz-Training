using System;
using System.IO;
using System.Collections.Generic;

class DetectDuplicatesCSV
{
    static void Main()
    {
        var ids = new HashSet<string>();

        using (StreamReader reader = new StreamReader("employees.csv"))
        {
            reader.ReadLine();
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split(',');
                string id = data[0];

                if (!ids.Add(id))
                {
                    Console.WriteLine("Duplicate Record Found: " + line);
                }
            }
        }
    }
}
