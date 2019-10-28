using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp
{
    abstract class Account
    {
        public int sum { get; set; } = 0 ;

        public List<Transaction> TransactionHistory = new List<Transaction>();
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string accountType { get; set; }

        //Open Account
    }
}
