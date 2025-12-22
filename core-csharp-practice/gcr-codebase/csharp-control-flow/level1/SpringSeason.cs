using System;
class SpringSeason
{
    static void Main()
    {
        Console.Write("Enter month: ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Enter day: ");
        int day = int.Parse(Console.ReadLine());

        bool isSpring =
            (month == 3 && day >= 20) ||
            (month == 4 || month == 5) ||
            (month == 6 && day <= 20);

        Console.WriteLine(isSpring ? "Its a Spring Season" : "Not a Spring Season");
    }
}
