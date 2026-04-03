using System;
using System.Collections.Generic;

class WordFrequency
{
    static void Main()
    {
        string text = "Hello world hello Java";
        text = text.ToLower();

        string[] words = text.Split(' ');
        Dictionary<string, int> freq = new Dictionary<string, int>();

        for (int i = 0; i < words.Length; i++)
        {
            if (freq.ContainsKey(words[i]))
            {
                freq[words[i]] = freq[words[i]] + 1;
            }
            else
            {
                freq.Add(words[i], 1);
            }
        }

        Console.WriteLine("Word Frequency:");
        string[] keys = new string[freq.Count];
        freq.Keys.CopyTo(keys, 0);

        for (int i = 0; i < keys.Length; i++)
        {
            Console.WriteLine(keys[i] + " : " + freq[keys[i]]);
        }
    }
}
