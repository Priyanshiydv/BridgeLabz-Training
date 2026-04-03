using System;

class Student
{
    public static string UniversityName = "Delhi University";
    private static int totalStudents = 0;

    public readonly int RollNumber;
    public string Name;
    public char Grade;

    public Student(string name, int rollNumber, char grade)
    {
        this.Name = name;
        this.RollNumber = rollNumber;
        this.Grade = grade;
        totalStudents++;
    }

    public static void DisplayTotalStudents()
    {
        Console.WriteLine("Total Students: " + totalStudents);
    }

    public void Display()
    {
        Console.WriteLine("University: " + UniversityName);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Roll Number: " + RollNumber);
        Console.WriteLine("Grade: " + Grade);
    }
}

class Program
{
    static void Main()
    {
        Student s1 = new Student("Neha", 401, 'A');

        if (s1 is Student)
        {
            s1.Display();
        }

        Student.DisplayTotalStudents();
    }
}
