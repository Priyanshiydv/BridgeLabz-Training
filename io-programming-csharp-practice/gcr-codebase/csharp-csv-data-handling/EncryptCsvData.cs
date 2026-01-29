using System;
using System.IO;
using System.Text;

class EncryptCsvData
{
    static void Main()
    {
        using (StreamWriter writer = new StreamWriter("secure.csv"))
        {
            writer.WriteLine("ID,Email,Salary");
            writer.WriteLine($"1,{Encrypt("rahul@email.com")},{Encrypt("60000")}");
        }

        Console.WriteLine("Encrypted CSV written.");

        using (StreamReader reader = new StreamReader("secure.csv"))
        {
            reader.ReadLine();
            string[] data = reader.ReadLine().Split(',');

            Console.WriteLine("Decrypted Data:");
            Console.WriteLine(Decrypt(data[1]));
            Console.WriteLine(Decrypt(data[2]));
        }
    }

    static string Encrypt(string text) =>
        Convert.ToBase64String(Encoding.UTF8.GetBytes(text));

    static string Decrypt(string cipher) =>
        Encoding.UTF8.GetString(Convert.FromBase64String(cipher));
}
