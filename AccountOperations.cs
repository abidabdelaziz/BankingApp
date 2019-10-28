using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp
{
    class AccountOperations
    {
        public static string custAction { get; set; }
        public static Account operatingAccount { get; set; }
        public static int operatingIndex { get; set; }
        public static void FindAccount(Account account, string action)
        {
            AccountOperations.operatingAccount = account;
            AccountOperations.custAction = action;
            //Handling Duplicates is an issue
            int toOperate = Program.custAccounts.IndexOf(account);
            
            Console.WriteLine(" The sum of the selected  account is {0} for a {1}", Program.custAccounts[toOperate].sum, custAction);

            SwitchAction(action);
        }

        public static void LogTransaction(string firstname,
                                          string lastname,
                                          string timestamp,
                                          string transtype,
                                          string accounttype,
                                          int transamount)
        {
            Transaction transObject = new Transaction(firstname, lastname, timestamp, transtype, accounttype, transamount);
            Program.custAccounts[operatingIndex].TransactionHistory.Add(transObject);
        }
        public static void SwitchAction(string action)
        {
            switch (action)
            {
                case "Deposit":

                    Console.WriteLine("How much would you like to deposit?");

                    var depAmount = Convert.ToInt32(Console.ReadLine());

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

                    Console.WriteLine("Which account would you like to review transaction history?");

                    var transHisAccount = Convert.ToInt32(Console.ReadLine());

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
            Program.custAccounts[operatingIndex].sum += amount;
        }

        public static void MakeWithdrawal(int amount)
        {
            Program.custAccounts[operatingIndex].sum -= amount;

            //Case for Overdraft needs implementation

        }

        public static void CloseAccount(int index)
        {
            Program.custAccounts.RemoveAt(index);

            //Devbug

        }
    }
}
