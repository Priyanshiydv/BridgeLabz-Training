using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

// User class
public class User
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = "";

    [JsonPropertyName("age")]
    public int Age { get; set; }

    [JsonPropertyName("email")]
    public string Email { get; set; } = "";
}

class FilterJson
{
    static void Main()
    {
        // Read JSON file
        string jsonData = File.ReadAllText("users.json");

        // Deserialize JSON array
        List<User> users = JsonSerializer.Deserialize<List<User>>(jsonData)!;

        // Filter users with age > 25
        Console.WriteLine("Users with Age > 25:");
        for (int i = 0; i < users.Count; i++)
        {
            if (users[i].Age > 25)
            {
                Console.WriteLine($"Name: {users[i].Name}, Age: {users[i].Age}, Email: {users[i].Email}");
            }
        }
    }
}
