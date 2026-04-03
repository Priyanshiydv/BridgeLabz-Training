using System;
using System.IO;
using System.Text.Json.Nodes;

class MergeJsonFiles
{
    static void Main()
    {
        // File paths
        string file1 = "user1.json";
        string file2 = "user2.json";

        // Sample JSON files (auto-create for demo)
        File.WriteAllText(file1, @"{ ""name"": ""Priya"", ""age"": 22 }");
        File.WriteAllText(file2, @"{ ""email"": ""priya@gmail.com"", ""city"": ""Delhi"" }");

        // Read JSON files
        JsonObject obj1 = JsonNode.Parse(File.ReadAllText(file1))!.AsObject();
        JsonObject obj2 = JsonNode.Parse(File.ReadAllText(file2))!.AsObject();

        // Merge objects
        foreach (var item in obj2)
        {
            // DeepClone avoids "node already has parent" error
            obj1[item.Key] = item.Value!.DeepClone();
        }

        // Output merged JSON
        Console.WriteLine("Merged JSON:");
        Console.WriteLine(obj1.ToJsonString(new System.Text.Json.JsonSerializerOptions
        {
            WriteIndented = true
        }));
    }
}
