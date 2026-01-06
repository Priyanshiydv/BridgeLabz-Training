using System;

// Interface for Medical Records
interface IMedicalRecord
{
    void AddRecord(string diagnosis);
    void ViewRecords();
}

// Abstract Patient class
abstract class Patient
{
    // Encapsulated fields (private)
    private int patientId;
    private string name;
    private int age;

    // Protected sensitive data
    protected string medicalHistory;

    // Public properties
    public int PatientId
    {
        get { return patientId; }
        set { patientId = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    // Constructor
    public Patient(int id, string name, int age)
    {
        PatientId = id;
        Name = name;
        Age = age;
        medicalHistory = "";
    }

    // Abstract method
    public abstract double CalculateBill();

    // Concrete method
    public void GetPatientDetails()
    {
        Console.WriteLine("Patient ID : " + PatientId);
        Console.WriteLine("Name       : " + Name);
        Console.WriteLine("Age        : " + Age);
    }
}

// InPatient class
class InPatient : Patient, IMedicalRecord
{
    private int daysAdmitted;
    private double dailyCharge;

    public InPatient(int id, string name, int age, int days, double charge)
        : base(id, name, age)
    {
        daysAdmitted = days;
        dailyCharge = charge;
    }

    public override double CalculateBill()
    {
        return daysAdmitted * dailyCharge;
    }

    public void AddRecord(string diagnosis)
    {
        medicalHistory = diagnosis;
    }

    public void ViewRecords()
    {
        Console.WriteLine("Medical History : " + medicalHistory);
    }
}

// OutPatient class
class OutPatient : Patient, IMedicalRecord
{
    private double consultationFee;

    public OutPatient(int id, string name, int age, double fee)
        : base(id, name, age)
    {
        consultationFee = fee;
    }

    public override double CalculateBill()
    {
        return consultationFee;
    }

    public void AddRecord(string diagnosis)
    {
        medicalHistory = diagnosis;
    }

    public void ViewRecords()
    {
        Console.WriteLine("Medical History : " + medicalHistory);
    }
}

// Main class
class Program
{
    static void Main()
    {
        // Polymorphism using Patient reference
        Patient[] patients = new Patient[2];

        InPatient p1 = new InPatient(101, "Ramesh", 45, 5, 2000);
        p1.AddRecord("Diabetes and Blood Pressure");

        OutPatient p2 = new OutPatient(102, "Sita", 30, 500);
        p2.AddRecord("Fever");

        patients[0] = p1;
        patients[1] = p2;

        // Using FOR loop 
        for (int i = 0; i < patients.Length; i++)
        {
            patients[i].GetPatientDetails();
            Console.WriteLine("Bill Amount : " + patients[i].CalculateBill());
            Console.WriteLine("----------------------------");
        }
    }
}
