using System;
using System.Text.RegularExpressions;

class LicensePlateValidation
{
    static void Main()
    {
        string pattern = @"^[A-Z]{2}\d{4}$";

        string[] plates = { "AB1234", "A12345", "XY9876" };

        for (int i = 0; i < plates.Length; i++)
        {
            if (Regex.IsMatch(plates[i], pattern))
                Console.WriteLine(plates[i] + " → Valid");
            else
                Console.WriteLine(plates[i] + " → Invalid");
        }
    }
}
