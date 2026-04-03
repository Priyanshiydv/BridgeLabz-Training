using System;
using System.Reflection;

// Custom Attribute
[AttributeUsage(AttributeTargets.Method)]
class TaskInfoAttribute : Attribute
{
    public string Priority { get; }
    public string AssignedTo { get; }

    public TaskInfoAttribute(string priority, string assignedTo)
    {
        Priority = priority;
        AssignedTo = assignedTo;
    }
}

class Program
{
    // Applying the attribute
    [TaskInfo("High", "Alice")]
    public static void CompleteTask()
    {
        Console.WriteLine("Task completed.");
    }

    static void Main()
    {
        MethodInfo method = typeof(Program).GetMethod("CompleteTask");

        var attr = method.GetCustomAttribute<TaskInfoAttribute>();

        Console.WriteLine("=== Task Info ===");
        Console.WriteLine("Priority: " + attr.Priority);
        Console.WriteLine("Assigned To: " + attr.AssignedTo);
    }
}
