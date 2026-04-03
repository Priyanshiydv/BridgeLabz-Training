using System;
using System.Collections.Generic;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class CacheResultAttribute : Attribute { }

class Program
{
    static Dictionary<int, int> cache = new Dictionary<int, int>();

    [CacheResult]
    public static int Square(int n)
    {
        Console.WriteLine("Computing...");
        return n * n;
    }

    static void Main()
    {
        MethodInfo method = typeof(Program).GetMethod("Square");

        int input = 5;

        if (!cache.ContainsKey(input))
            cache[input] = (int)method.Invoke(null, new object[] { input });

        Console.WriteLine("Result: " + cache[input]);
        Console.WriteLine("Result: " + cache[input]); // Cached
    }
}
