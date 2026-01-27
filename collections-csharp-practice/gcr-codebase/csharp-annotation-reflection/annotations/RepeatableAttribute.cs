using System;
using System.Reflection;

// Repeatable Attribute
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class BugReportAttribute : Attribute
{
    public string Description { get; }

    public BugReportAttribute(string description)
    {
        Description = description;
    }
}

class Program
{
    // Applying attribute multiple times
    [BugReport("Null reference exception occurs")]
    [BugReport("UI not refreshing after update")]
    public static void RunSoftware()
    {
        Console.WriteLine("Software running...");
    }

    static void Main()
    {
        MethodInfo method = typeof(Program).GetMethod("RunSoftware");

        var bugs = method.GetCustomAttributes<BugReportAttribute>();

        Console.WriteLine("=== Bug Reports ===");
        foreach (var bug in bugs)
        {
            Console.WriteLine("Bug: " + bug.Description);
        }
    }
}
