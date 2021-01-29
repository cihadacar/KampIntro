using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        //Method injection
        public void MakeApplication(ILoanBaseManager loanBaseManager, ILoggerService loggerService)
        {
            //Başvuru değerelendirme
            //vs. vs.
            loanBaseManager.Calculate();
            loggerService.Log();
        }
        
        public void LoanPreInformation(List<ILoanBaseManager> loans)
        {
            foreach (var loan in loans)
            {
                loan.Calculate();
            }
        }
    }
}
