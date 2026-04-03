using System;
using System.Reflection;

// Sample class to test
class Sample
{
    public int id;
    private string name;

    public Sample() { }
    public Sample(int i) { id = i; }

    public void Show() { }
    private void HiddenMethod() { }
}

class ClassInfoReflection
{
    static void Main()
    {
        Console.Write("Enter class name: ");
        string className = Console.ReadLine();

        // Get type information
        Type type = Type.GetType(className);

        if (type == null)
        {
            Console.WriteLine("Class not found!");
            return;
        }

        Console.WriteLine("\nClass Name: " + type.Name);

        // 🔹 Get Methods
        MethodInfo[] methods = type.GetMethods(
            BindingFlags.Public | BindingFlags.NonPublic |
            BindingFlags.Instance | BindingFlags.DeclaredOnly);

        Console.WriteLine("\nMethods:");
        for (int i = 0; i < methods.Length; i++)
        {
            Console.WriteLine(methods[i].Name);
        }

        // 🔹 Get Fields
        FieldInfo[] fields = type.GetFields(
            BindingFlags.Public | BindingFlags.NonPublic |
            BindingFlags.Instance | BindingFlags.DeclaredOnly);

        Console.WriteLine("\nFields:");
        for (int i = 0; i < fields.Length; i++)
        {
            Console.WriteLine(fields[i].Name);
        }

        // 🔹 Get Constructors
        ConstructorInfo[] constructors = type.GetConstructors(
            BindingFlags.Public | BindingFlags.NonPublic |
            BindingFlags.Instance);

        Console.WriteLine("\nConstructors:");
        for (int i = 0; i < constructors.Length; i++)
        {
            Console.WriteLine(constructors[i]);
        }
    }
}
