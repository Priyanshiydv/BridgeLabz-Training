using System;
using System.Collections.Generic;

// Abstract class
abstract class CourseType
{
    public abstract void Evaluate();
}

class ExamCourse : CourseType
{
    public override void Evaluate()
    {
        Console.WriteLine("Exam based evaluation");
    }
}

// Generic class
class Course<T> where T : CourseType
{
    private List<T> courses = new List<T>();

    public void AddCourse(T course)
    {
        courses.Add(course);
    }

    public void ShowCourses()
    {
        for (int i = 0; i < courses.Count; i++)
        {
            courses[i].Evaluate();
        }
    }
}

class UniversityCourseManagement
{
    static void Main()
    {
        Course<ExamCourse> course = new Course<ExamCourse>();
        course.AddCourse(new ExamCourse());
        course.ShowCourses();
    }
}
