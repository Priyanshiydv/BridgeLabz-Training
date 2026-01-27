using System;
using System.Reflection;
using System.Text;

[AttributeUsage(AttributeTargets.Field)]
class JsonFieldAttribute : Attribute
{
    public string Name { get; set; }
}

class User
{
    [JsonField(Name = "user_name")]
    public string Name = "Priya";

    [JsonField(Name = "user_age")]
    public int Age = 22;
}

class Program
{
    static void Main()
    {
        User u = new User();
        StringBuilder json = new StringBuilder("{ ");

        foreach (var field in typeof(User).GetFields())
        {
            var attr = field.GetCustomAttribute<JsonFieldAttribute>();
            if (attr != null)
                json.Append($"\"{attr.Name}\": \"{field.GetValue(u)}\", ");
        }

        json.Length -= 2;
        json.Append(" }");
        Console.WriteLine(json);
    }
}
