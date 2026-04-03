using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class TodoAttribute : Attribute
{
    public string Task { get; }
    public string AssignedTo { get; }
    public string Priority { get; set; } = "MEDIUM";

    public TodoAttribute(string task, string assignedTo)
    {
        Task = task;
        AssignedTo = assignedTo;
    }
}

class Program
{
    [Todo("Add login feature", "Priya", Priority = "HIGH")]
    [Todo("Improve UI", "Rahul")]
    public static void FeatureModule() { }

    static void Main()
    {
        var methods = typeof(Program).GetMethods();
        foreach (var m in methods)
        {
            var todos = m.GetCustomAttributes<TodoAttribute>();
            foreach (var t in todos)
                Console.WriteLine($"Task: {t.Task}, Assigned: {t.AssignedTo}, Priority: {t.Priority}");
        }
    }
}
