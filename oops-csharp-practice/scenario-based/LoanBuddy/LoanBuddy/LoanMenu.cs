using System;

namespace LoanBuddy
{
    internal class LoanMenu
    {
        public void Start()
        {
            Console.Write("Enter Applicant Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Credit Score: ");
            int creditScore = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Monthly Income: ");
            double income = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Loan Amount: ");
            double loanAmount = Convert.ToDouble(Console.ReadLine());

            Applicant applicant =
                new Applicant(name, creditScore, income, loanAmount);

            Console.WriteLine("\nSelect Loan Type:");
            Console.WriteLine("1. Home Loan");
            Console.WriteLine("2. Auto Loan");
            Console.Write("Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            LoanApplication loan;

            if (choice == 1)
                loan = new HomeLoan(20);
            else
                loan = new AutoLoan(5);

            LoanUtilityImpl service =
                new LoanUtilityImpl(applicant, loan);

            service.ApproveLoan();
            service.CalculateEMI();
        }
    }
}
