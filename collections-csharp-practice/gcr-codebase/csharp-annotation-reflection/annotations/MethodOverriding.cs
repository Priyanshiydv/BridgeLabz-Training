using System;

// Parent Class
class Animal
{
    // Virtual method (can be overridden)
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

// Child Class
class Dog : Animal
{
    // Overriding parent method
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks: Woof Woof!");
    }
}

// Main Class
class Program
{
    static void Main()
    {
        Dog d = new Dog();   // Create Dog object
        d.MakeSound();       // Calls overridden method
    }
}
