using System;

class CharacterRemover
{
    
    public static string RemoveCharacter(string text, char charToRemove)
    {
        string result = "";

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] != charToRemove)
            {
                result += text[i];
            }
        }
        return result;
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Console.Write("Enter character to remove: ");
        char ch = Console.ReadKey().KeyChar;
        Console.WriteLine();

        string modified = RemoveCharacter(input, ch);
        Console.WriteLine("Modified String: " + modified);
    }
}
