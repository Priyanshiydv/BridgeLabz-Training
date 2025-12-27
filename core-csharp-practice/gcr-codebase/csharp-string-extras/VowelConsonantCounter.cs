using System;

class VowelConsonantCounter
{
    public static void CountVowelsAndConsonants(string s, out int vowels, out int consonants)
    {
        vowels = 0;
        consonants = 0;

        for (int i = 0; i < s.Length; i++)
        {
            char ch = char.ToLower(s[i]);

            if (ch >= 'a' && ch <= 'z')
            {
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                    vowels++;
                else
                    consonants++;
            }
        }
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        CountVowelsAndConsonants(input, out int v, out int c);
        Console.WriteLine($"Vowels: {v}, Consonants: {c}");
    }
}
