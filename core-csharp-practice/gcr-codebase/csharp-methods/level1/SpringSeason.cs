using System;

class SpringSeason
{
    // Method to check Spring Season
    public static bool IsSpringSeason(int month, int day)
    {
        if ((month == 3 && day >= 20) ||
            (month == 4) ||
            (month == 5) ||
            (month == 6 && day <= 20))
        {
            return true;
        }

        return false;
    }

    static void Main(string[] args)
    {
        // Taking user input 
        Console.Write("Enter month: ");
        int month = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter day: ");
        int day = Convert.ToInt32(Console.ReadLine());

        bool result = IsSpringSeason(month, day);

        if (result)
            Console.WriteLine("Its a Spring Season");
        else
            Console.WriteLine("Not a Spring Season");
    }
}
