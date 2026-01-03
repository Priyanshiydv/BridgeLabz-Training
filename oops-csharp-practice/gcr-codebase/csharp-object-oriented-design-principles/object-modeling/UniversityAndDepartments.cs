using System;
using System.Collections.Generic;

class Faculty
{
    public string Name;
    public Faculty(string name)
    {
        Name = name;
    }
}

class Department
{
    public string Name;
    public Department(string name)
    {
        Name = name;
    }
}

class University
{
    public List<Department> Departments = new List<Department>();
    public List<Faculty> Faculties = new List<Faculty>();
}

class UniversityAndDepartments
{
    static void Main()
    {
        University uni = new University();
        uni.Departments.Add(new Department("CS"));
        uni.Faculties.Add(new Faculty("Dr. Rao"));

        Console.WriteLine("University created.");
        uni = null; // Departments removed, faculties can exist independently
    }
}
