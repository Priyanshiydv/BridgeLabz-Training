using System;
using System.IO;
using System.Collections.Generic;

class ReadLargeCSV
{
    static void Main()
    {
        string path = "largefile.csv";
        int totalProcessed = 0;
        var buffer = new List<string>();

        using (StreamReader reader = new StreamReader(path))
        {
            reader.ReadLine(); // skip header
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                buffer.Add(line);

                if (buffer.Count == 100)
                {
                    ProcessChunk(buffer);
                    totalProcessed += buffer.Count;
                    buffer.Clear();
                }
            }

            // Process remaining lines
            if (buffer.Count > 0)
            {
                ProcessChunk(buffer);
                totalProcessed += buffer.Count;
            }
        }

        Console.WriteLine($"Total Records Processed: {totalProcessed}");
    }

    static void ProcessChunk(List<string> lines)
    {
        // Simulate processing
        Console.WriteLine($"Processing {lines.Count} records...");
    }
}
