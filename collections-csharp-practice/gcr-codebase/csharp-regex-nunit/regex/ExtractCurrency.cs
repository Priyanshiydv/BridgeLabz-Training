using System;
using System.Text.RegularExpressions;

class ExtractCurrency
{
    static void Main()
    {
        string input = "The price is $45.99, and the discount is $ 10.50.";
        string pattern = @"\$?\s?\d+\.\d{2}";

        MatchCollection matches = Regex.Matches(input, pattern);

        for (int i = 0; i < matches.Count; i++)
            Console.WriteLine(matches[i].Value.Trim());
    }
}
