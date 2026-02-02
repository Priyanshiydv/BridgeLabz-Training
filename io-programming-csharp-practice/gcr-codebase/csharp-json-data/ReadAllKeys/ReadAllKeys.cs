using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Nodes;

class ReadAllKeys
{
    static void Main()
    {
        // Read JSON file
        string jsonData = File.ReadAllText("data.json");

        // Parse JSON into dynamic object
        JsonNode node = JsonNode.Parse(jsonData)!;

        Console.WriteLine("Keys and Values in JSON:");

        // Loop through all key-value pairs
        foreach (var kvp in node.AsObject())
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }
    }
}
