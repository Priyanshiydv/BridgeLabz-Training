using System;
using System.Text.Json;
using System.Text.Json.Nodes;

class FilterAge
{
    static void Main()
    {
        // JSON data (normally comes from file)
        string jsonData = @"[
            { ""name"": ""Priya"", ""age"": 22 },
            { ""name"": ""Rahul"", ""age"": 30 },
            { ""name"": ""Anita"", ""age"": 27 },
            { ""name"": ""Karan"", ""age"": 21 }
        ]";

        // Parse JSON array
        JsonArray people = JsonNode.Parse(jsonData).AsArray();

        Console.WriteLine("People with Age > 25:\n");

        // Loop using for (NOT foreach)
        for (int i = 0; i < people.Count; i++)
        {
            JsonObject person = people[i].AsObject();

            int age = person["age"].GetValue<int>();

            if (age > 25)
            {
                string name = person["name"].GetValue<string>();
                Console.WriteLine("Name: " + name + ", Age: " + age);
            }
        }
    }
}
