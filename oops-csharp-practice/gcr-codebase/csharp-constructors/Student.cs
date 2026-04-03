using System;

class Student
{
    public int rollNumber;
    protected string name;
    private double cgpa;

    public void SetCGPA(double c)
    {
        cgpa = c;
    }

    public double GetCGPA()
    {
        return cgpa;
    }
}

class PostgraduateStudent : Student
{
    static void Main()
    {
        PostgraduateStudent s = new PostgraduateStudent();
        s.rollNumber = 101;
        s.name = "Sneha";
        s.SetCGPA(8.5);

        Console.WriteLine("Roll: " + s.rollNumber);
        Console.WriteLine("Name: " + s.name);
        Console.WriteLine("CGPA: " + s.GetCGPA());
    }
}
