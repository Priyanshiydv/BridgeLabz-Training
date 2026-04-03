using System;
using System.Collections.Generic;
using System.Reflection;

class User
{
    public string Name;
    public int Age;
}

class ObjectMapper
{
    static T ToObject<T>(Dictionary<string, object> data)
    {
        T obj = Activator.CreateInstance<T>();
        FieldInfo[] fields = typeof(T).GetFields();

        for (int i = 0; i < fields.Length; i++)
        {
            if (data.ContainsKey(fields[i].Name))
                fields[i].SetValue(obj, data[fields[i].Name]);
        }
        return obj;
    }

    static void Main()
    {
        Dictionary<string, object> dict = new Dictionary<string, object>();
        dict["Name"] = "Priya";
        dict["Age"] = 22;

        User u = ToObject<User>(dict);
        Console.WriteLine(u.Name + " " + u.Age);
    }
}
