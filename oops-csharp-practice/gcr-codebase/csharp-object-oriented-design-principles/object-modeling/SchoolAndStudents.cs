using System;
using System.Collections.Generic;

class Course
{
    public string CourseName;
    public List<Student> Students = new List<Student>();

    public Course(string name)
    {
        CourseName = name;
    }
}

class Student
{
    public string Name;
    public List<Course> Courses = new List<Course>();

    public Student(string name)
    {
        Name = name;
    }

    public void Enroll(Course course)
    {
        Courses.Add(course);
        course.Students.Add(this);
    }

    public void ViewCourses()
    {
        Console.WriteLine($"{Name}'s Courses:");
        foreach (Course c in Courses)
            Console.WriteLine("- " + c.CourseName);
    }
}

class School
{
    public List<Student> Students = new List<Student>();
}

class SchoolAndStudents
{
    static void Main()
    {
        Student s1 = new Student("Priya");
        Course c1 = new Course("Math");
        Course c2 = new Course("Science");

        s1.Enroll(c1);
        s1.Enroll(c2);

        s1.ViewCourses();
    }
}
