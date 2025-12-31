using System;

class Course
{
    string courseName;
    int duration;
    int fee;
    static string instituteName = "BridgeLabz";

    Course(string c, int d, int f)
    {
        courseName = c;
        duration = d;
        fee = f;
    }

    void DisplayCourseDetails()
    {
        Console.WriteLine("Course: " + courseName);
        Console.WriteLine("Institute: " + instituteName);
    }

    static void UpdateInstituteName(string name)
    {
        instituteName = name;
    }

    static void Main()
    {
        Course.UpdateInstituteName("BridgeLabz India");
        Course c = new Course("C#", 30, 5000);
        c.DisplayCourseDetails();
    }
}
