using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp
{
    abstract class Account
    {
        public int sum { get; set; } = 0 ;
        public List<string> TransactionHistory = new List<string>();
        public string firstName { get; set; }
        public string lastName { get; set; }

        //Open Account
    }
}
