using System;
using System.Text.RegularExpressions;

class FindRepeatingWords
{
    static void Main()
    {
        string input = "This is is a repeated repeated word test.";
        string pattern = @"\b(\w+)\s+\1\b";

        MatchCollection matches = Regex.Matches(input, pattern, RegexOptions.IgnoreCase);

        for (int i = 0; i < matches.Count; i++)
            Console.WriteLine(matches[i].Groups[1].Value);
    }
}
