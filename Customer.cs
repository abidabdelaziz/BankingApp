using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp
{
    class Customer
    {
        public List<Account> Accounts = new List<Account>();
        public bool isRegistered { get; set; } = false;
        public int totalReturns { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public Customer(string firstn, string lastn )
        {
            firstName = firstn;
            lastName = lastn;
            Accounts = new List<Account>();
            isRegistered = !isRegistered;

        }

    }
}
