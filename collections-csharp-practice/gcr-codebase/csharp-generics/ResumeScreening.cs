using System;
using System.Collections.Generic;

// Abstract job role
abstract class JobRole
{
    public abstract void EvaluateResume();
}

class SoftwareEngineer : JobRole
{
    public override void EvaluateResume()
    {
        Console.WriteLine("Software Engineer Resume Evaluated");
    }
}

// Generic resume class
class Resume<T> where T : JobRole
{
    private List<T> resumes = new List<T>();

    public void AddResume(T role)
    {
        resumes.Add(role);
    }

    public void ScreenResumes()
    {
        for (int i = 0; i < resumes.Count; i++)
        {
            resumes[i].EvaluateResume();
        }
    }
}

class ResumeScreening
{
    static void Main()
    {
        Resume<SoftwareEngineer> system = new Resume<SoftwareEngineer>();
        system.AddResume(new SoftwareEngineer());
        system.ScreenResumes();
    }
}
