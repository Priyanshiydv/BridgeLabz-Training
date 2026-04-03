using System;
using System.Text.RegularExpressions;

class ExtractLanguages
{
    static void Main()
    {
        string input = "I love Java, Python, and JavaScript, but I haven't tried Go yet.";
        string pattern = @"\b(Java|Python|JavaScript|Go)\b";

        MatchCollection matches = Regex.Matches(input, pattern);

        for (int i = 0; i < matches.Count; i++)
            Console.WriteLine(matches[i].Value);
    }
}
