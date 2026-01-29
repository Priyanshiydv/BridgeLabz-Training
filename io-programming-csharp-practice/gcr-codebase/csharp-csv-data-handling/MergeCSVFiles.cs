using System;
using System.IO;
using System.Collections.Generic;

class MergeCSVFiles
{
    static void Main()
    {
        var marksData = new Dictionary<string, string>();

        // Read second file
        using (StreamReader reader = new StreamReader("students2.csv"))
        {
            reader.ReadLine(); // skip header
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split(',');
                marksData[data[0]] = data[1] + "," + data[2];
            }
        }

        var output = new List<string>();
        output.Add("ID,Name,Age,Marks,Grade");

        // Merge with first file
        using (StreamReader reader = new StreamReader("students1.csv"))
        {
            reader.ReadLine();
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split(',');
                string id = data[0];

                if (marksData.ContainsKey(id))
                {
                    output.Add(line + "," + marksData[id]);
                }
            }
        }

        File.WriteAllLines("merged_students.csv", output);
        Console.WriteLine("Files merged successfully!");
    }
}
