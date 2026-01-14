using System;

namespace LoanBuddy
{
    internal class HomeLoan : LoanApplication
    {
        public HomeLoan(int term)
            : base(term, 0.08, "Home Loan")
        {
        }

        public override double CalculateEMI(double principal)
        {
            double r = interestRate / 12;
            int n = term * 12;

            return (principal * r * Math.Pow(1 + r, n)) /
                   (Math.Pow(1 + r, n) - 1);
        }
    }
}
