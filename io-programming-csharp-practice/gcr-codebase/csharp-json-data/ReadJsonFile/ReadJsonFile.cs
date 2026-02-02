using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

// User class to match JSON structure
public class User
{
    public string Name { get; set; } = "";
    public string Email { get; set; } = "";
    public int Age { get; set; }
}

class ReadJsonFile
{
    static void Main()
    {
        // Read JSON file
        string jsonData = File.ReadAllText("users.json");

        // Deserialize JSON array into List<User>
        List<User> users = JsonSerializer.Deserialize<List<User>>(jsonData)!;

        // Print only name and email
        Console.WriteLine("Name and Email from JSON:");
        for (int i = 0; i < users.Count; i++)
        {
            Console.WriteLine($"Name: {users[i].Name}, Email: {users[i].Email}");
        }
    }
}
