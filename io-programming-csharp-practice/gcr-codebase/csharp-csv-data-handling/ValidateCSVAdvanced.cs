using System;
using System.IO;
using System.Text.RegularExpressions;

class ValidateCSVAdvanced
{
    static void Main()
    {
        string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        string phonePattern = @"^\d{10}$";

        using (StreamReader reader = new StreamReader("users.csv"))
        {
            string line;
            reader.ReadLine(); // skip header

            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split(',');

                string name = data[1];
                string email = data[2];
                string phone = data[3];

                if (!Regex.IsMatch(email, emailPattern))
                    Console.WriteLine($"Invalid Email for {name}");

                if (!Regex.IsMatch(phone, phonePattern))
                    Console.WriteLine($"Invalid Phone for {name}");
            }
        }
    }
}
