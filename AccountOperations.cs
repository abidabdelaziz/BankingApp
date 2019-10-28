using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp
{
    class AccountOperations
    {
        public static string custAction { get; set; }
        public static Account operatingAccount { get; set; }
        public static int originIndex { get; set; }
        public static void FindAccount(Account account, string action)
        {
            AccountOperations.operatingAccount = account;
            AccountOperations.custAction = action;
            //Handling Duplicates is an issue
            int toOperate = Program.custAccounts.IndexOf(account);
            AccountOperations.originIndex = toOperate;
            
            Console.WriteLine(" The sum of the selected  account is {0} for a {1}", Program.custAccounts[toOperate].sum, custAction);

            SwitchAction(action);
        }

        public static void LogTransaction(string firstname,
                                          string lastname,
                                          DateTime timestamp,
                                          string transtype,
                                          int transamount)
        {
            Transaction transObject = new Transaction(firstname, lastname, timestamp, transtype, transamount);
            Program.custAccounts[originIndex].TransactionHistory.Add(transObject);


        }
        public static void SwitchAction(string action)
        {
            switch (action)
            {
                case "Deposit":

                    Console.WriteLine("How much would you like to deposit?");

                    int depAmount = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Processing deposit.");

                    MakeDeposit(depAmount);

                    Console.WriteLine("Deposit Complete.");

                    break;
                case "Withdraw":

                    Console.WriteLine("How much would you like to withdraw?");

                    var withAmount = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Processing withdrawal.");

                    MakeWithdrawal(withAmount);

                    Console.WriteLine("Withdrawal Complete.");


                    break;
                case "Transfer":

                    Console.WriteLine("How much would you like to transfer?");

                    var transAmount = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("To Which Account would you like to transfer?");

                    //Function to display accounts from Program Class

                    var transAccount = Console.ReadLine();

                    break;
                case "Transaction History":

                    TransactionHistory();

                    break;

                case "Close":

                    // Function to remove operating account from Program list
                    break;
                case "Payment":

                    Console.WriteLine("How much would you like to pay?");

                    var paymentAmount = Convert.ToInt32(Console.ReadLine());

                    break;
                default:

                    FindAccount(operatingAccount, custAction);

                    break;
            }

        }
        public static void MakeDeposit(int amount)
        {
            Program.custAccounts[originIndex].sum += amount;

            DateTime tStamp = DateTime.Now;

            LogTransaction(operatingAccount.firstName,
                           operatingAccount.lastName,
                           tStamp,
                           custAction,
                           amount);
        }

        public static void MakeWithdrawal(int amount)
        {
            Program.custAccounts[originIndex].sum -= amount;

            DateTime tStamp = DateTime.Now;

            LogTransaction(operatingAccount.firstName,
                         operatingAccount.lastName,
                         tStamp,
                         custAction,
                         amount);

            //Case for Overdraft needs implementation

        }

        public static void TransactionHistory()
        {
            List < Transaction > transactions = operatingAccount.TransactionHistory;
            int listLength = transactions.Count;

            for (var i = 0; i < listLength; i++)
            {
                Console.WriteLine(" {0} the index", i);
                Console.WriteLine("Account {0} :{1} {2} - Amount : {3}   Type : {4}", i, transactions[i].fName, 
                                                                                        transactions[i].lName, 
                                                                                        transactions[i].transAmount, 
                                                                                        transactions[i].transType);
            };

            Console.WriteLine("Press any key to continue.");

            string proceed = Console.ReadLine();
        }
        public static void CloseAccount(int index)
        {
            Program.custAccounts.RemoveAt(index);



            //Devbug

        }
    }
}
