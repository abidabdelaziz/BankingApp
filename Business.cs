using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp
{
    class Business : Account
    {
        public static List<Transaction> transactionHistory = new List<Transaction>();
        public const int overDraft = 500;



        public Business(string fName, string lName, string type, int deposit)
        {
            base.firstName = fName;
            base.lastName = lName;
            base.accountType = type;
            base.sum = deposit;

        }
    }

}
