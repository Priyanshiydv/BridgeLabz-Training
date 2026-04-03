using System;

class ArgumentOutOfRange
{
    public static void GenerateSubstring(string text)
    {
        try
        {
            Console.WriteLine(text.Substring(5, 2));
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("ArgumentOutOfRangeException caught: " + ex.Message);
        }
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();

        GenerateSubstring(text);
    }
}
