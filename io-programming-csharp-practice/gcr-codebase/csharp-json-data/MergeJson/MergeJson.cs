using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Nodes;

class MergeJson
{
    static void Main()
    {
        // Read first JSON
        string json1 = File.ReadAllText("student1.json");
        JsonNode node1 = JsonNode.Parse(json1)!;

        // Read second JSON
        string json2 = File.ReadAllText("student2.json");
        JsonNode node2 = JsonNode.Parse(json2)!;

        // Merge node2 into node1 (clone values to avoid parent issue)
        foreach (var kvp in node2.AsObject())
        {
            node1[kvp.Key] = kvp.Value?.DeepClone();
        }

        // Print merged JSON
        string mergedJson = node1.ToJsonString(new JsonSerializerOptions { WriteIndented = true });
        Console.WriteLine("Merged JSON:");
        Console.WriteLine(mergedJson);
    }
}
