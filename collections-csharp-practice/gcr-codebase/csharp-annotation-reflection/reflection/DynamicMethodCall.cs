using System;
using System.Reflection;

class MathOperations
{
    public int Add(int a, int b) { return a + b; }
    public int Subtract(int a, int b) { return a - b; }
    public int Multiply(int a, int b) { return a * b; }
}

class DynamicMethodCall
{
    static void Main()
    {
        MathOperations m = new MathOperations();
        Type type = typeof(MathOperations);

        Console.Write("Enter method name (Add/Subtract/Multiply): ");
        string methodName = Console.ReadLine();

        MethodInfo method = type.GetMethod(methodName);

        object result = method.Invoke(m, new object[] { 10, 5 });

        Console.WriteLine("Result: " + result);
    }
}
