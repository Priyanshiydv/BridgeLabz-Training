using System;
class FriendsComparison
{
    static void Main()
    {
        Console.Write("Enter Amar's age: ");
        int amarAge = int.Parse(Console.ReadLine());
        Console.Write("Enter Amar's height: ");
        double amarHeight = double.Parse(Console.ReadLine());

        Console.Write("Enter Akbar's age: ");
        int akbarAge = int.Parse(Console.ReadLine());
        Console.Write("Enter Akbar's height: ");
        double akbarHeight = double.Parse(Console.ReadLine());

        Console.Write("Enter Anthony's age: ");
        int anthonyAge = int.Parse(Console.ReadLine());
        Console.Write("Enter Anthony's height: ");
        double anthonyHeight = double.Parse(Console.ReadLine());

        // Youngest
        if (amarAge < akbarAge && amarAge < anthonyAge)
            Console.WriteLine("Amar is the youngest");
        else if (akbarAge < anthonyAge)
            Console.WriteLine("Akbar is the youngest");
        else
            Console.WriteLine("Anthony is the youngest");

        // Tallest
        if (amarHeight > akbarHeight && amarHeight > anthonyHeight)
            Console.WriteLine("Amar is the tallest");
        else if (akbarHeight > anthonyHeight)
            Console.WriteLine("Akbar is the tallest");
        else
            Console.WriteLine("Anthony is the tallest");
    }
}
