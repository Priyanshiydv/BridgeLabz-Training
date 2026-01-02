using System;
class MathematicalOperations
{
    static void Main()
    {
        Console.WriteLine("1. Factorial");
        Console.WriteLine("2. Check a number if it is prime or not");
        Console.WriteLine("3. find GCD");
        Console.WriteLine("4. Fibonacci value");
        int i = int.Parse(Console.ReadLine());

        switch (i)
        {
            case 1:{
                Console.WriteLine("Enter a Number");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(Factorial(n));}
                break;

            case 2:{
                Console.WriteLine("Enter a Number");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(Prime(n));}
                break;

            case 3:
                Console.WriteLine("Enter first number");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("GCD is");
                Console.WriteLine(GreatestCommonDivisor(a, b));
                break;
            case 4:{ 
                Console.WriteLine("Enter a Number");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(Fibonacci(n));}
                break;
        }

    }
    static int Factorial(int n)
    {
        int fact = 1;
        for (int i = 1; i <= n; i++)
        {
            fact = fact * i;
        }
        return fact;
    }
    static bool Prime(int n)
    {
        int count = 0;
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                count++;
            }
        }
        if (count == 2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static int GreatestCommonDivisor(int a, int b)
    {
        int[] arr1 = new int[a];
        int[] arr2 = new int[b];
        int counta = 0;
        int countb = 0;
        for (int i = 1; i <= a; i++)
        {
            if (a % i == 0)
            {
                arr1[counta++] = i;
            }
        }
        for (int i = 1; i <= b; i++)
        {
            if (b % i == 0)
            {
                arr2[countb++] = i;
            }
        }
        int gcd = 1;
        for (int i = 0; i < counta; i++)
        {
            for (int j = 0; j < countb; j++)
            {
                if (arr1[i] == arr2[j])
                {
                    gcd = arr1[i];
                }
            }
        }
        return gcd;
    }

    static int Fibonacci(int n)
    {
        if (n == 0)
        {
            return 0;
        }
        if (n == 1)
        {
            return 1;
        }
        int first = 0;
        int second = 1;
        int res = 0;
        for (int i = 2; i <= n; i++)
        {
            res = first + second;
            first = second;
            //0+1 1+1 2+3
            second = res;

        }
        return res;
    }

}