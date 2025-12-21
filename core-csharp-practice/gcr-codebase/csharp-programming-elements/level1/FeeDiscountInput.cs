using System;
class FeeDiscountInput
{
    static void Main(string[] args)
    {
        double fee;
        double discountPercent;
        Console.Write("Enter the course fee: ");
        fee = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the discount percentage: ");
        discountPercent = Convert.ToDouble(Console.ReadLine());

        double discountAmount = (fee * discountPercent) / 100;
        double finalFee = fee - discountAmount;
        Console.WriteLine(
            "The discount amount is INR " + discountAmount +
            " and final discounted fee is INR " + finalFee
        );
    }
}
