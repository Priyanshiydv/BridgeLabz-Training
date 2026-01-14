using System;

namespace LoanBuddy
{
    internal class LoanUtilityImpl : IApprovable
    {
        private Applicant applicant;
        private LoanApplication loan;
        private bool isApproved;   // restricted access

        public LoanUtilityImpl(Applicant applicant, LoanApplication loan)
        {
            this.applicant = applicant;
            this.loan = loan;
        }

        public void ApproveLoan()
        {
            if (applicant.CreditScore >= 650 && applicant.Income >= 30000)
            {
                isApproved = true;
                Console.WriteLine("\nLoan Approved for " + applicant.Name);
            }
            else
            {
                isApproved = false;
                Console.WriteLine("\nLoan Rejected for " + applicant.Name);
            }
        }

        public void CalculateEMI()
        {
            if (!isApproved)
            {
                Console.WriteLine("EMI cannot be calculated. Loan not approved.");
                return;
            }

            double emi = loan.CalculateEMI(applicant.LoanAmount);
            Console.WriteLine("Monthly EMI: ₹" + (int)emi);
        }
    }
}
