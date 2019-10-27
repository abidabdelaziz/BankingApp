using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankingApp
{
   
    class ActionMenu
    {
        public List<Account> actionAccounts = new List<Account>();


       
        public static void DisplayAccounts(List<Account> accounts)
        {
            var listLength = accounts.Count();
            for ( var i = 0; i< listLength; i++)
            {
                Console.WriteLine(" {0} the index", i);
                Console.WriteLine("Account {0} - Sum : {1}   Maturity : {2}" , i, accounts[i].sum, ((CD)accounts[i]).maturity);
            };
        }

        public static void DisplayActionMenu(List<Account> accounts)
        {
            List<Account> actionAccounts = accounts;
            Console.WriteLine("Account Type {0}", actionAccounts.First().sum);

            string menuOption= actionAccounts.First().accountType;
            string action;
            switch (menuOption)
            {
               
                case "Checking":

                    //Checking Options
                    Console.WriteLine("Checking Options");
                    Console.WriteLine("\t1 - Deposit");
                    Console.WriteLine("\t2 - Withdraw");
                    Console.WriteLine("\t3 - Transfer");
                    Console.WriteLine("\t4 - Transaction History");
                    Console.WriteLine("\t5 - Close");
                    Console.WriteLine("\t6 - Back");
                    Console.WriteLine("\t7 - Exit");

                    action = Console.ReadLine();


                    break;
                case "Business":

                    //Business Options
                    Console.WriteLine("Business Options");
                    Console.WriteLine("\t1 - Deposit");
                    Console.WriteLine("\t2 - Withdraw");
                    Console.WriteLine("\t3 - Transfer");
                    Console.WriteLine("\t4 - Transaction History");
                    Console.WriteLine("\t5 - Close");
                    Console.WriteLine("\t6 - Back");
                    Console.WriteLine("\t7 - Exit");

                    action = Console.ReadLine();

                    break;

                case "CD":

                    ActionMenu.DisplayAccounts( actionAccounts );
                    //CD Options
                    Console.WriteLine("CD Options");
                    Console.WriteLine("\t1 - Withdraw");
                    Console.WriteLine("\t2 - Back");
                    Console.WriteLine("\t3 - Exit");

                    action = Console.ReadLine();

                    break;

                case "Loan":

                    //Loan Options
                    Console.WriteLine("Loan Options");
                    Console.WriteLine("\t1 - Deposit-Payment");
                    Console.WriteLine("\t2 - Transaction History");
                    Console.WriteLine("\t3 - Back");
                    Console.WriteLine("\t4 - Exit");

                    action = Console.ReadLine();

                    break;

                default:

                   
                    break;
            }
        }
    }
}
