using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading;

class Work
{
    public void Task() { Thread.Sleep(500); }
}

class MethodTiming
{
    static void Main()
    {
        Work w = new Work();
        MethodInfo method = typeof(Work).GetMethod("Task");

        Stopwatch sw = Stopwatch.StartNew();
        method.Invoke(w, null);
        sw.Stop();

        Console.WriteLine("Execution Time: " + sw.ElapsedMilliseconds + " ms");
    }
}
