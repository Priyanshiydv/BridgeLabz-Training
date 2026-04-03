using System;
using System.Text.RegularExpressions;

class CreditCardValidation
{
    static void Main()
    {
        string pattern = @"^([45]\d{15})$";

        string[] cards = { "4123456789012345", "5123456789012345", "6123456789012345" };

        for (int i = 0; i < cards.Length; i++)
        {
            if (Regex.IsMatch(cards[i], pattern))
                Console.WriteLine(cards[i] + " → Valid");
            else
                Console.WriteLine(cards[i] + " → Invalid");
        }
    }
}
