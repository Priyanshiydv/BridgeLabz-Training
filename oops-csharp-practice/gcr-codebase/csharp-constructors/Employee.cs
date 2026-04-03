using System;

class Employee
{
    public int employeeID;
    protected string department;
    private int salary;

    public void SetSalary(int s)
    {
        salary = s;
    }
}

class Manager : Employee
{
    static void Main()
    {
        Manager m = new Manager();
        m.employeeID = 9001;
        m.department = "IT";
        m.SetSalary(80000);

        Console.WriteLine("ID: " + m.employeeID);
        Console.WriteLine("Department: " + m.department);
    }
}
