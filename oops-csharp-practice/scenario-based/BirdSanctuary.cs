using System;
//06-01-2026
// Flyable interface
interface IFlyable
{
    void Fly();
}

// Swimmable interface
interface ISwimmable
{
    void Swim();
}

// Base class
class Bird
{
    protected string Name;
    protected string Color;

    public Bird(string name, string color)
    {
        Name = name;
        Color = color;
    }

    // Polymorphic method
    public virtual void DisplayInfo()
    {
        Console.WriteLine("Bird Name: " + Name + ", Color: " + Color);
    }
}

// Eagle can fly
class Eagle : Bird, IFlyable
{
    public Eagle(string name, string color) : base(name, color) { }

    public void Fly()
    {
        Console.WriteLine(Name + " is flying high in the sky.");
    }
}

// Sparrow can fly
class Sparrow : Bird, IFlyable
{
    public Sparrow(string name, string color) : base(name, color) { }

    public void Fly()
    {
        Console.WriteLine(Name + " is flying small distances.");
    }
}

// Duck can swim
class Duck : Bird, ISwimmable
{
    public Duck(string name, string color) : base(name, color) { }

    public void Swim()
    {
        Console.WriteLine(Name + " is swimming in the pond.");
    }
}

// Penguin can swim
class Penguin : Bird, ISwimmable
{
    public Penguin(string name, string color) : base(name, color) { }

    public void Swim()
    {
        Console.WriteLine(Name + " is swimming in cold water.");
    }
}

// Seagull can fly and swim
class Seagull : Bird, IFlyable, ISwimmable
{
    public Seagull(string name, string color) : base(name, color) { }

    public void Fly()
    {
        Console.WriteLine(Name + " is flying near the sea.");
    }

    public void Swim()
    {
        Console.WriteLine(Name + " is swimming on sea water.");
    }
}

// Main class
class BirdSanctuary
{
    static void Main(string[] args)
    {
        // Array of Bird objects (Array Concept)
        Bird[] birds = new Bird[5];

        birds[0] = new Eagle("Eagle", "Brown");
        birds[1] = new Sparrow("Sparrow", "Grey");
        birds[2] = new Duck("Duck", "White");
        birds[3] = new Penguin("Penguin", "Black & White");
        birds[4] = new Seagull("Seagull", "White");

        // Polymorphism with interface checking
        for (int i = 0; i < birds.Length; i++)
        {
            birds[i].DisplayInfo();

            if (birds[i] is IFlyable)
            {
                ((IFlyable)birds[i]).Fly();
            }

            if (birds[i] is ISwimmable)
            {
                ((ISwimmable)birds[i]).Swim();
            }

            Console.WriteLine("-------------------------");
        }
    }
}
