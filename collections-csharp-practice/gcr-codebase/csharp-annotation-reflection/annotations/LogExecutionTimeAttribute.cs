using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading;

[AttributeUsage(AttributeTargets.Method)]
class LogExecutionTimeAttribute : Attribute { }

class Program
{
    [LogExecutionTime]
    public static void Task1() { Thread.Sleep(500); }

    [LogExecutionTime]
    public static void Task2() { Thread.Sleep(1000); }

    static void Main()
    {
        foreach (var method in typeof(Program).GetMethods())
        {
            if (method.GetCustomAttribute<LogExecutionTimeAttribute>() != null)
            {
                Stopwatch sw = Stopwatch.StartNew();
                method.Invoke(null, null);
                sw.Stop();
                Console.WriteLine($"{method.Name} took {sw.ElapsedMilliseconds} ms");
            }
        }
    }
}
