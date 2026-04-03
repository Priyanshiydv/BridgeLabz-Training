using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class WordCountTop5
{
    static void Main()
    {
        string fileName = "log.txt"; // same file from Question 1
        Dictionary<string, int> wordFrequency = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

        try
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    // Split line into words using Regex to handle punctuation
                    string[] words = Regex.Split(line, @"\W+");

                    foreach (string word in words)
                    {
                        if (!string.IsNullOrWhiteSpace(word))
                        {
                            if (wordFrequency.ContainsKey(word))
                                wordFrequency[word]++;
                            else
                                wordFrequency[word] = 1;
                        }
                    }
                }
            }

            // Get top 5 most frequent words
            var topWords = wordFrequency.OrderByDescending(kv => kv.Value).Take(5);

            Console.WriteLine("Top 5 most frequent words:");
            foreach (var kv in topWords)
            {
                Console.WriteLine($"{kv.Key} -> {kv.Value}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading the file: " + ex.Message);
        }
    }
}
