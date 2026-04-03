using System;
using System.Reflection;
using System.Text;

class Person
{
    public string Name = "Priya";
    public int Age = 22;
}

class ObjectToJson
{
    static void Main()
    {
        Person p = new Person();
        FieldInfo[] fields = typeof(Person).GetFields();
        StringBuilder json = new StringBuilder("{ ");

        for (int i = 0; i < fields.Length; i++)
        {
            json.Append("\"" + fields[i].Name + "\": \"" +
                        fields[i].GetValue(p) + "\"");

            if (i < fields.Length - 1) json.Append(", ");
        }
        json.Append(" }");

        Console.WriteLine(json);
    }
}
