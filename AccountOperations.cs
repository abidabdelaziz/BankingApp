using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankingApp
{
    class AccountOperations
    {
        public static string custAction { get; set; }
        public static Account operatingAccount { get; set; }
        public static int originIndex { get; set; }
        public static string fallbackAction { get; set; }
        public static void FindAccount(Account account, string action)
        {
            AccountOperations.fallbackAction = action;
            AccountOperations.operatingAccount = account;
            AccountOperations.custAction = action;
            //Handling Duplicates is an issue
            int toOperate = Program.custAccounts.IndexOf(account);
            AccountOperations.originIndex = toOperate;
            
            Console.WriteLine(" You have accessed your {0} Account with sum {1} for a {2}", Program.custAccounts[toOperate].accountType,
                                                                                           Program.custAccounts[toOperate].sum, 
                                                                                           custAction);

            // maybe remove fall back action and load message if var is null then fire another menu
            SwitchAction(custAction);
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

                   
                    Console.WriteLine("To Which Account would you like to transfer?");

                    Account transferAccount = ReturnTransferAccount();                

                    int transferAmount = TransferCheck();

                    MakeTransfer(transferAccount, transferAmount);


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

                    ActionMenu.DisplayActionMenu(operatingAccount);

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

        public static void MakeTransfer(Account tAccount, int tTransfer)
        {
            Program.custAccounts[originIndex].sum -= tTransfer;

            int refIndex = Program.custAccounts.FindIndex(account => account == tAccount);

            Program.custAccounts[refIndex].sum += tTransfer;

            DateTime tStamp = DateTime.Now;

            //Also Log in Account receiving transfer
            Transaction transObject = new Transaction(Program.custAccounts[refIndex].firstName,
                Program.custAccounts[refIndex].lastName,
                tStamp,
                custAction,
                tTransfer);
            Program.custAccounts[refIndex].TransactionHistory.Add(transObject);

            LogTransaction(operatingAccount.firstName,
                           operatingAccount.lastName,
                           tStamp,
                           custAction,
                           tTransfer);
            Console.WriteLine("Thank you for your Transfer");
        }

        public static int TransferCheck()
        {
            
            var choiceValid = false;

            int validTransfer = 0;

            while (!choiceValid)
            {
                Console.WriteLine("How much would you like to transfer?");

                int tAmount = Convert.ToInt32(Console.ReadLine());

                if (tAmount < operatingAccount.sum)
                {
                    validTransfer = tAmount;
                    choiceValid = true;
                   
                }else
                {
                    continue;
                }

            }

            return validTransfer;
        }

        public static Account ReturnTransferAccount()
        {
            var totransferAccs = Program.custAccounts.Where(item => item.accountType == "Checking" ||
                                                                   item.accountType == "Business" ||
                                                                   item.accountType == "Loan").ToList();

            var listLength = totransferAccs.Count();

            for (var i = 0; i < listLength; i++)
            {
                Console.WriteLine("Account {0} - Sum : {1}   Type : {2}", i, totransferAccs[i].sum, totransferAccs[i].accountType);
            };

            int transferChoice = Convert.ToInt32(Console.ReadLine());

            return Program.custAccounts[transferChoice] ;
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
