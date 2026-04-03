using System;
using System.Collections.Generic;

class Employee
{
    public string Name;
    public Employee(string name)
    {
        Name = name;
    }
}

class Department
{
    public string DeptName;
    public List<Employee> Employees = new List<Employee>();

    public Department(string name)
    {
        DeptName = name;
    }

    public void AddEmployee(string name)
    {
        Employees.Add(new Employee(name));
    }
}

class Company
{
    public string CompanyName;
    public List<Department> Departments = new List<Department>();

    public Company(string name)
    {
        CompanyName = name;
    }

    public void AddDepartment(Department dept)
    {
        Departments.Add(dept);
    }
}

class CompanyAndDepartment
{
    static void Main()
    {
        Company company = new Company("TechCorp");

        Department d1 = new Department("IT");
        d1.AddEmployee("Amit");

        company.AddDepartment(d1);

        Console.WriteLine("Company created with departments.");
        company = null; // All departments & employees removed
        Console.WriteLine("Company deleted.");
    }
}
