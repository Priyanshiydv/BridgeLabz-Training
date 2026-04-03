using System;

class FormatException
{
    public static void ParseInvalidNumber()
    {
        try
        {
            int number = int.Parse("ABC");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("FormatException caught: " + ex.Message);
        }
    }

    static void Main()
    {
        ParseInvalidNumber();
    }
}
