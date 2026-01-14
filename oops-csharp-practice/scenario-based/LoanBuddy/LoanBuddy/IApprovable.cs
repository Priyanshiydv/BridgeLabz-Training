using System;

namespace LoanBuddy
{
    internal interface IApprovable
    {
        void ApproveLoan();
        void CalculateEMI();
    }
}
