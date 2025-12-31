using System;

class Person
{
    string name;
    int age;

    Person(string n, int a)
    {
        name = n;
        age = a;
    }

    // Copy constructor
    Person(Person p)
    {
        name = p.name;
        age = p.age;
    }

    void Display()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }

    static void Main()
    {
        Person p1 = new Person("Amit", 22);
        Person p2 = new Person(p1);
        p2.Display();
    }
}
