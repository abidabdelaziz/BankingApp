using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp
{
    class Checking : Account
    {
        public int maturity;




        public Checking(string fName, string lName, string type, int deposit)
        {
            base.firstName = fName;
            base.lastName = lName;
            base.accountType = type;
            base.sum = deposit;

        }
    }

}
