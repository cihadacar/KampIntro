using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class MortgageLoanManager : ILoanBaseManager
    {
        public void Calculate()
        {
            Console.WriteLine("Mortgage loan payment plan calculated.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
