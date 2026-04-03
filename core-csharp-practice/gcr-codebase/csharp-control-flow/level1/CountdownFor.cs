using System;
class CountdownFor
{
    static void Main()
    {
        Console.Write("Enter countdown start value: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = n; i >= 1; i--)
        {
            Console.WriteLine(i);
        }
    }
}
