using System;

class MostFrequentCharacter
{
    
    public static char FindMostFrequentCharacter(string s)
    {
        int[] frequency = new int[256];
        int maxCount = 0;
        char mostFrequentChar = '\0';

       
        for (int i = 0; i < s.Length; i++)
        {
            frequency[s[i]]++;
        }

        
        for (int i = 0; i < s.Length; i++)
        {
            if (frequency[s[i]] > maxCount)
            {
                maxCount = frequency[s[i]];
                mostFrequentChar = s[i];
            }
        }

        return mostFrequentChar;
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        char result = FindMostFrequentCharacter(input);

        Console.WriteLine($"Most Frequent Character: '{result}'");
    }
}
