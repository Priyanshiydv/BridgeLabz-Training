using System;
using System.Reflection;

class Configuration
{
    private static string API_KEY = "OLD_KEY";
}

class StaticFieldModify
{
    static void Main()
    {
        Type type = typeof(Configuration);
        FieldInfo field = type.GetField("API_KEY",
            BindingFlags.NonPublic | BindingFlags.Static);

        field.SetValue(null, "NEW_KEY");

        Console.WriteLine("Updated API Key: " + field.GetValue(null));
    }
}
