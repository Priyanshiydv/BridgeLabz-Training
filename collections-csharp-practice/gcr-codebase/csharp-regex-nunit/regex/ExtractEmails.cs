using System;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main()
    {
        string input = "Contact us at support@example.com and info@company.org";
        string pattern = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}\b";

        MatchCollection matches = Regex.Matches(input, pattern);

        for (int i = 0; i < matches.Count; i++)
            Console.WriteLine(matches[i].Value);
    }
}
