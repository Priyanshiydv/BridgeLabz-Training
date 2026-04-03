using System;

class UppercaseConverter
{
    public static string ConvertToUppercase(string text)
    {
        char[] result = new char[text.Length];

        for (int i = 0; i < text.Length; i++)
        {
            char ch = text[i];
            if (ch >= 'a' && ch <= 'z')
                result[i] = (char)(ch - 32);
            else
                result[i] = ch;
        }
        return new string(result);
    }

    static void Main()
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        Console.WriteLine("Custom Uppercase: " + ConvertToUppercase(text));
        Console.WriteLine("Built-in Uppercase: " + text.ToUpper());
    }
}
