using System;
class CountdownWhile
{
    static void Main()
    {
        Console.Write("Enter countdown start value: ");
        int counter = int.Parse(Console.ReadLine());

        while (counter >= 1)
        {
            Console.WriteLine(counter);
            counter--;
        }
    }
}
