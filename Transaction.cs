using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp
{
    class Transaction
    {
        public string fName { get; set; }
        public string lName { get; set; }
        public DateTime timeStamp { get; set; }
        public string transType { get; set; }
        public string accountType { get; set;  }
        public int transAmount { get; set; }


        public Transaction( string firstname,
                            string lastname,
                            DateTime timestamp,
                            string transtype,
                            int transamount)
        {
            fName = firstname;
            lName = lastname;
            timeStamp = timestamp;
            transType = transtype;
            transAmount = transamount;
        }




    }
}
