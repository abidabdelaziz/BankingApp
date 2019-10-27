using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp
{
    class Business : Account
    {
        public int maturity;




        public Business(string fName, string lName, string type, int deposit)
        {
            base.firstName = fName;
            base.lastName = lName;
            base.accountType = type;
            base.sum = deposit;

        }
    }

}
