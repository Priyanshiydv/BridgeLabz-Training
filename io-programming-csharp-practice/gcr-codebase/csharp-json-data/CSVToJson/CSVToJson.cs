using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

class CsvToJson
{
    static void Main()
    {
        string csvFile = "students.csv";

        // Create sample CSV file
        File.WriteAllText(csvFile,
@"Name,Age,City
Amit,23,Mumbai
Neha,26,Delhi
Ravi,28,Bangalore");

        var lines = File.ReadAllLines(csvFile);
        var headers = lines[0].Split(',');

        List<Dictionary<string, string>> data = new List<Dictionary<string, string>>();

        for (int i = 1; i < lines.Length; i++)
        {
            var values = lines[i].Split(',');
            Dictionary<string, string> row = new Dictionary<string, string>();

            for (int j = 0; j < headers.Length; j++)
            {
                row[headers[j]] = values[j];
            }

            data.Add(row);
        }

        // Convert to JSON
        string json = JsonConvert.SerializeObject(data, Formatting.Indented);

        Console.WriteLine("CSV converted to JSON:\n");
        Console.WriteLine(json);
    }
}
