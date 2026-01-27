using System;
using System.Text.RegularExpressions;

class ExtractLinks
{
    static void Main()
    {
        string input = "Visit https://www.google.com and http://example.org for more info.";
        string pattern = @"https?://[^\s]+";

        MatchCollection matches = Regex.Matches(input, pattern);

        for (int i = 0; i < matches.Count; i++)
            Console.WriteLine(matches[i].Value);
    }
}
