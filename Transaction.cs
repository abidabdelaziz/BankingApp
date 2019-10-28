using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp
{
    class Transaction
    {
        public string fName { get; set; }
        public string lName { get; set; }
        public string timeStamp { get; set; }
        public string transType { get; set; }
        public string accountType { get; set;  }
        public int transAmount { get; set; }


        public Transaction( string firstname,
                            string lastname,
                            string timestamp,
                            string transtype,
                            string accounttype,
                            int transamount)
        {
            fName = firstname;
            lName = lastname;
            timeStamp = timestamp;
            transType = transtype;
            accountType = accounttype;
            transAmount = transamount;
        }




    }
}
