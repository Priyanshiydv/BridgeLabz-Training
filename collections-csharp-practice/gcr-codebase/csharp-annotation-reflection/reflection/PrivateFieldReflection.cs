using System;
using System.Reflection;

class Person
{
    private int age = 20;
}

class PrivateFieldReflection
{
    static void Main()
    {
        Person p = new Person();
        Type type = typeof(Person);

        FieldInfo field = type.GetField("age",
            BindingFlags.NonPublic | BindingFlags.Instance);

        Console.WriteLine("Old Age: " + field.GetValue(p));

        field.SetValue(p, 35);

        Console.WriteLine("New Age: " + field.GetValue(p));
    }
}
