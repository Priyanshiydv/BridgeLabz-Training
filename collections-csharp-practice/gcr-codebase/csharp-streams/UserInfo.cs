using System;
using System.IO;

class UserInfo
{
    static void Main()
    {
        string filePath = "user_info.txt";

        try
        {
            // StreamReader to read from Console
            StreamReader reader = new StreamReader(Console.OpenStandardInput());

            Console.Write("Enter your name: ");
            string name = reader.ReadLine();

            Console.Write("Enter your age: ");
            string age = reader.ReadLine();

            Console.Write("Enter your favorite programming language: ");
            string language = reader.ReadLine();

            // StreamWriter to write into file
            StreamWriter writer = new StreamWriter(filePath);

            writer.WriteLine("Name: " + name);
            writer.WriteLine("Age: " + age);
            writer.WriteLine("Favorite Language: " + language);

            writer.Close();

            Console.WriteLine("\nData saved successfully into user_info.txt");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}
