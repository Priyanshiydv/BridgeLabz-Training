using System;

class GcdLcmCalculator
{
    static int FindGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static int FindLCM(int a, int b)
    {
        return (a * b) / FindGCD(a, b);
    }

    static void Main()
    {
        Console.Write("Enter two numbers: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("GCD: " + FindGCD(a, b));
        Console.WriteLine("LCM: " + FindLCM(a, b));
    }
}
