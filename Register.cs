using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp
{
    class Register
    {
        public Customer newCust;

        public Customer RegisterCustomer (string firstn , string lastn)
        {

            Customer newCust = new Customer(firstn, lastn);

            return newCust ;
        }
    }
}
