using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankingApp
{

    class ActionMenu
    {
        public static List<Account> actionAccounts = new List<Account>();
        public static Account operatingAccount { get; set; }

        public static string customerAction {get;set;}
       
        public static void DisplayAccounts(List<Account> accounts)
        {
            ActionMenu.actionAccounts = accounts;
            Console.WriteLine("Please indicate an account from the following : ");
            
            var listLength = accounts.Count();
            int custIndication;
           

            for ( var i = 0; i< listLength; i++)
            {
                Console.WriteLine("Account {0} - Sum : {1}   Type : {2}" , i, actionAccounts[i].sum, actionAccounts[i].accountType);
            };

            Console.WriteLine("Please enter the account number.");
            
            custIndication = Convert.ToInt32(Console.ReadLine());
    

            operatingAccount = actionAccounts[custIndication];

            DisplayActionMenu(operatingAccount);
        }

        public static void DisplayActionMenu(Account account)
        {

            string menuOption = account.accountType;
            
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

                    ActionMenu.customerAction = Console.ReadLine();

                    AccountOperations.FindAccount(operatingAccount, customerAction);

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

                    ActionMenu.customerAction = Console.ReadLine();

                    AccountOperations.FindAccount(operatingAccount, customerAction);

                    break;

                case "CD":
                    //CD Options
                    Console.WriteLine("CD Options");
                    Console.WriteLine("\t1 - Withdraw");
                    Console.WriteLine("\t2 - Back");
                    Console.WriteLine("\t3 - Exit");

                    ActionMenu.customerAction = Console.ReadLine();

                    AccountOperations.FindAccount(operatingAccount, customerAction);

                    break;

                case "Loan":

                    //Loan Options
                    Console.WriteLine("Loan Options");
                    Console.WriteLine("\t1 - Payment");
                    Console.WriteLine("\t2 - Transaction History");
                    Console.WriteLine("\t3 - Back");
                    Console.WriteLine("\t4 - Exit");

                    ActionMenu.customerAction = Console.ReadLine();

                    AccountOperations.FindAccount(operatingAccount, customerAction);

                    break;

                default:

                    DisplayActionMenu(operatingAccount);

                    break;
            }
        }
    }
}
