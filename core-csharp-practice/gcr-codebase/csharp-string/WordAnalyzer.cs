using System;

class WordAnalyzer
{
    public static int GetLength(string word)
    {
        int count = 0;
        foreach (char ch in word)
            count++;
        return count;
    }

    public static string[,] SplitWordsAndLengths(string text)
    {
        string[] words = text.Split(' ');
        string[,] result = new string[words.Length, 2];

        for (int i = 0; i < words.Length; i++)
        {
            result[i, 0] = words[i];
            result[i, 1] = GetLength(words[i]).ToString();
        }
        return result;
    }

    static void Main()
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        string[,] output = SplitWordsAndLengths(text);

        Console.WriteLine("Word\tLength");
        for (int i = 0; i < output.GetLength(0); i++)
        {
            Console.WriteLine($"{output[i, 0]}\t{output[i, 1]}");
        }
    }
}
