using System;
class VolumeOfCylinder
{
    static void Main(string[] args)
    {
        double radius = 2.0;
        double height = 8.0;
        double volume = Math.PI * radius * radius * height;
        Console.WriteLine("Volume of the cylinder is: " + volume);
    }
}
