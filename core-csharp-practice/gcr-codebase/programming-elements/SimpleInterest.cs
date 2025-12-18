using System;
class SimpleInterest
{
    static void Main(string[] args)
    {
        double principal = 10000;
        double rate = 5;      
        double time = 2;      
        double interest = (principal * rate * time) / 100;
        Console.WriteLine("Simple Interest is: " + interest);
    }
}
