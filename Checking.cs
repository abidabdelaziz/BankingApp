using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp
{
    class Checking : Account
    {
        public static List<Transaction> transactionHistory = new List<Transaction>();
        public int fixedInterest = 3;



        public Checking(string fName, string lName, string type, int deposit)
        {
            base.firstName = fName;
            base.lastName = lName;
            base.accountType = type;
            base.sum = deposit;

        }
    }

}
