using System;

class StringReverse
{
    public static string ReverseString(string s)
    {
        string reversed = "";

        for (int i = s.Length - 1; i >= 0; i--)
        {
            reversed += s[i];
        }
        return reversed;
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Console.WriteLine("Reversed String: " + ReverseString(input));
    }
}
