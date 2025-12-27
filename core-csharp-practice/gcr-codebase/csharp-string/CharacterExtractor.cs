using System;

class CharacterExtractor
{
    public static char[] GetCharacters(string text)
    {
        char[] characters = new char[text.Length];

        for (int i = 0; i < text.Length; i++)
        {
            characters[i] = text[i];
        }
        return characters;
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();

        char[] customChars = GetCharacters(text);
        char[] builtInChars = text.ToCharArray();

        Console.WriteLine("Custom Method Result: " + string.Join(", ", customChars));
        Console.WriteLine("Built-in Method Result: " + string.Join(", ", builtInChars));
    }
}
