using System;

class LowercaseConverter
{
    public static string ConvertToLowercase(string text)
    {
        char[] result = new char[text.Length];

        for (int i = 0; i < text.Length; i++)
        {
            char ch = text[i];
            if (ch >= 'A' && ch <= 'Z')
                result[i] = (char)(ch + 32);
            else
                result[i] = ch;
        }
        return new string(result);
    }

    static void Main()
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        Console.WriteLine("Custom Lowercase: " + ConvertToLowercase(text));
        Console.WriteLine("Built-in Lowercase: " + text.ToLower());
    }
}
