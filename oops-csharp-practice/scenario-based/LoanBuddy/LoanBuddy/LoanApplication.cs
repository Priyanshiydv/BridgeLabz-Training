using System;

namespace LoanBuddy
{
    internal abstract class LoanApplication
    {
        protected int term;              // in years
        protected double interestRate;
        protected string loanType;

        public LoanApplication(int term, double interestRate, string loanType)
        {
            this.term = term;
            this.interestRate = interestRate;
            this.loanType = loanType;
        }

        public abstract double CalculateEMI(double principal);
    }
}
