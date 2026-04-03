using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class ImportantMethodAttribute : Attribute
{
    public string Level { get; }
    public ImportantMethodAttribute(string level = "HIGH")
    {
        Level = level;
    }
}

class Program
{
    [ImportantMethod]  // Default HIGH
    public static void SaveData() { }

    [ImportantMethod("CRITICAL")]
    public static void DeleteAll() { }

    static void Main()
    {
        foreach (var method in typeof(Program).GetMethods())
        {
            var attr = method.GetCustomAttribute<ImportantMethodAttribute>();
            if (attr != null)
                Console.WriteLine($"{method.Name} → Importance: {attr.Level}");
        }
    }
}
