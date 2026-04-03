using System;
using System.IO;

class ImageToByte
{
    static void Main()
    {
        string inputImage = "input.jpg";
        string outputImage = "output.jpg";

        try
        {
            // Read image file into byte array
            byte[] imageBytes;
            using (FileStream fs = new FileStream(inputImage, FileMode.Open, FileAccess.Read))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    fs.CopyTo(ms);          // copy file data to memory
                    imageBytes = ms.ToArray(); // convert to byte array
                }
            }

            Console.WriteLine("Image converted to byte array.");

            // Write byte array back to new image file
            using (FileStream fs = new FileStream(outputImage, FileMode.Create, FileAccess.Write))
            {
                fs.Write(imageBytes, 0, imageBytes.Length);
            }

            Console.WriteLine("Byte array written back to image file.");
            Console.WriteLine("Image copied successfully.");
        }
        catch (IOException e)
        {
            Console.WriteLine("File error: " + e.Message);
        }
    }
}
