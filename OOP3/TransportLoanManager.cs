using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TransportLoanManager : ILoanBaseManager
    {
        public void Calculate()
        {
            Console.WriteLine("Transport loan payment plan calculated.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
