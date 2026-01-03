using System;

class Patient
{
    public static string HospitalName = "City Hospital";
    private static int totalPatients = 0;

    public readonly int PatientID;
    public string Name;
    public int Age;
    public string Ailment;

    public Patient(string name, int age, string ailment, int patientId)
    {
        this.Name = name;
        this.Age = age;
        this.Ailment = ailment;
        this.PatientID = patientId;
        totalPatients++;
    }

    public static void GetTotalPatients()
    {
        Console.WriteLine("Total Patients: " + totalPatients);
    }

    public void Display()
    {
        Console.WriteLine("Hospital: " + HospitalName);
        Console.WriteLine("Patient ID: " + PatientID);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Ailment: " + Ailment);
    }
}

class Program
{
    static void Main()
    {
        Patient p1 = new Patient("Divya", 25, "Fever", 501);

        if (p1 is Patient)
        {
            p1.Display();
        }

        Patient.GetTotalPatients();
    }
}
