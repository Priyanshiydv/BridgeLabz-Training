using System;
class ChocolateDistribution
{
    static void Main(string[] args)
    {
        int numOfChocolates, numOfChildren;
        Console.Write("Enter number of chocolates: ");
        numOfChocolates = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number of children: ");
        numOfChildren = Convert.ToInt32(Console.ReadLine());

        int chocolates = numOfChocolates / numOfChildren;
        int remaining = numOfChocolates % numOfChildren;

        Console.WriteLine(
            "The number of chocolates each child gets is " +
            chocolates +
            " and the number of remaining chocolates is " + remaining
        );
    }
}
