using System;

class Patient
{
    public string Name;

    public Patient(string name)
    {
        Name = name;
    }
}

class Doctor
{
    public string Name;

    public Doctor(string name)
    {
        Name = name;
    }

    public void Consult(Patient patient)
    {
        Console.WriteLine("Dr. " + Name + " is consulting " + patient.Name);
    }
}

class Hospital
{
    static void Main()
    {
        Doctor d1 = new Doctor("Sharma");
        Patient p1 = new Patient("Ravi");

        d1.Consult(p1);
    }
}
