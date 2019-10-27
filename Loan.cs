using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp
{
    class Loan : Account
    {
        public int maturity;




        public Loan(string fName, string lName, string type, int deposit)
        {
            base.firstName = fName;
            base.lastName = lName;
            base.accountType = type;
            base.sum = deposit;

        }
    }

}
