using System;

class Student
{
    public string Name;
    public Student(string name)
    {
        Name = name;
    }
}

class DynamicObjectCreation
{
    static void Main()
    {
        Type type = typeof(Student);
        object obj = Activator.CreateInstance(type, "Priya");

        Console.WriteLine(((Student)obj).Name);
    }
}
