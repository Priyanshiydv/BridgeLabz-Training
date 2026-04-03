using System;
using System.Reflection;

class Calculator
{
    private int Multiply(int a, int b)
    {
        return a * b;
    }
}

class PrivateMethodInvoke
{
    static void Main()
    {
        Calculator c = new Calculator();
        Type type = typeof(Calculator);

        MethodInfo method = type.GetMethod("Multiply",
            BindingFlags.NonPublic | BindingFlags.Instance);

        object result = method.Invoke(c, new object[] { 5, 4 });

        Console.WriteLine("Multiplication Result: " + result);
    }
}
