using System;

class StringIndexException
{
    public static void AccessInvalidIndex(string text)
    {
        try
        {
            Console.WriteLine(text[100]);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("IndexOutOfRangeException caught: " + ex.Message);
        }
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();

        AccessInvalidIndex(text);
    }
}
