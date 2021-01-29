using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ILoanBaseManager  personalFinanceLoanManager = new PersonalFinanceLoanManager();
            ILoanBaseManager transportLoanManager = new TransportLoanManager();
            ILoanBaseManager mortgageLoanManager = new MortgageLoanManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeApplication(personalFinanceLoanManager, databaseLoggerService);
            applicationManager.MakeApplication(mortgageLoanManager, fileLoggerService);
            //applicationManager.MakeApplication(transportLoanManager);
            //applicationManager.MakeApplication(mortgageLoanManager);

            List<ILoanBaseManager> loans = new List<ILoanBaseManager>() { personalFinanceLoanManager, transportLoanManager, mortgageLoanManager };

            //applicationManager.LoanPreInformation(loans);


        }
    }
}
