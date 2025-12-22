using System;

class LargestNumber
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int n2 = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        int n3 = int.Parse(Console.ReadLine());

        Console.WriteLine($"Is the first number the largest? {n1 > n2 && n1 > n3}");
        Console.WriteLine($"Is the second number the largest? {n2 > n1 && n2 > n3}");
        Console.WriteLine($"Is the third number the largest? {n3 > n1 && n3 > n2}");
    }
}
