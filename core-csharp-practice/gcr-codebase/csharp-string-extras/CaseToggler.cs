using System;

class CaseToggler
{
    public static string ToggleCase(string text)
    {
        char[] result = new char[text.Length];

        for (int i = 0; i < text.Length; i++)
        {
            char ch = text[i];

            if (ch >= 'A' && ch <= 'Z')
                result[i] = (char)(ch + 32);
            else if (ch >= 'a' && ch <= 'z')
                result[i] = (char)(ch - 32);
            else
                result[i] = ch;
        }
        return new string(result);
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Console.WriteLine("Toggled String: " + ToggleCase(input));
    }
}
