using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp
{
    class CD : Account
    {
        public int maturity { get; set; }
        public DateTime depositDate { get; set; }




        public CD(string fName, string lName, string type, int tmaturity, int deposit, DateTime timestamp)
        {
            base.firstName = fName;
            base.lastName = lName;
            base.accountType = type;
            base.sum = deposit;
            maturity = tmaturity;
            depositDate = timestamp;
        }
    }

}

