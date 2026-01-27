using System;
using System.Text.RegularExpressions;

class ExtractCapitalWords
{
    static void Main()
    {
        string input = "The Eiffel Tower is in Paris and the Statue of Liberty is in New York.";
        string pattern = @"\b[A-Z][a-z]+\b";

        MatchCollection matches = Regex.Matches(input, pattern);

        for (int i = 0; i < matches.Count; i++)
            Console.WriteLine(matches[i].Value);
    }
}
