using System;
using System.IO;

class StudentData
{
    static void Main()
    {
        string filePath = Path.Combine(Directory.GetCurrentDirectory(), "students.dat");

        try
        {
            // ===== WRITING DATA =====
            using (FileStream fsWrite = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            using (BinaryWriter writer = new BinaryWriter(fsWrite))
            {
                writer.Write(1);               // Roll Number
                writer.Write("Amit");          // Name
                writer.Write(8.5);             // GPA

                writer.Write(2);
                writer.Write("Neha");
                writer.Write(9.1);
            }

            Console.WriteLine("Student data written successfully.\n");

            // ===== READING DATA =====
            using (FileStream fsRead = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (BinaryReader reader = new BinaryReader(fsRead))
            {
                while (fsRead.Position < fsRead.Length)
                {
                    int roll = reader.ReadInt32();
                    string name = reader.ReadString();
                    double gpa = reader.ReadDouble();

                    Console.WriteLine("Roll No: " + roll);
                    Console.WriteLine("Name   : " + name);
                    Console.WriteLine("GPA    : " + gpa);
                    Console.WriteLine("--------------------");
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("File error: " + e.Message);
        }
    }
}
