using System;

class OTPGenerator
{
    public static int GenerateOTP()
    {
        Random r = new Random();
        return r.Next(100000, 999999);
    }

    public static bool IsUnique(int[] otps)
    {
        for (int i = 0; i < otps.Length; i++)
        {
            for (int j = i + 1; j < otps.Length; j++)
            {
                if (otps[i] == otps[j])
                    return false;
            }
        }
        return true;
    }

    static void Main()
    {
        int[] otps = new int[10];

        for (int i = 0; i < 10; i++)
        {
            otps[i] = GenerateOTP();
            Console.WriteLine("OTP " + (i + 1) + ": " + otps[i]);
        }

        Console.WriteLine(IsUnique(otps) ? "All OTPs are Unique" : "Duplicate OTP Found");
    }
}
