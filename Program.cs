using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace BankingApp
{
    class Program
    {
        public static List<Account> custAccounts = new List<Account>() ;
        public static Customer currentCustomer { get; set ; }
        public static string fName { get; set; }
        public static string lName { get; set; }
        public static int custTicker { get; set; } = 0;
        public static string menuOption { get; set; }
        public static string actionPointer { get; set; }
        static void Main(string[] args)
        {
            bool endApp = false;
         
            while (!endApp)
            {
                bool exitMenu = false;


                /*Console.WriteLine("---------------------------\r");
                Console.WriteLine("Welcome To Your Banking App\r");
                Console.WriteLine("---------------------------\n");
                Console.WriteLine("--Press Enter to Continue--\n");

                string logOn = Console.ReadLine();

                Console.WriteLine("---------------------------\r");
                Console.WriteLine("Please Type your First Name\r");
                Console.WriteLine("---------------------------\n");

                //Replace This method of setting with validation
                string fName = Console.ReadLine();

                Console.WriteLine("---------------------------\r");
                Console.WriteLine("Please Type your Last Name\r");
                Console.WriteLine("---------------------------\n");

                //Replace This method of setting with validation
                string lName = Console.ReadLine();*/

                Register.WelcomePrompt();

                


                Console.WriteLine("Welcome {0} {1} ", currentCustomer.firstName, currentCustomer.lastName  );

                /*   Console.WriteLine("Choose an Account from the following list:");
                   Console.WriteLine("\t1 - Checking");
                   Console.WriteLine("\t2 - Business");
                   Console.WriteLine("\t3 - CD");
                   Console.WriteLine("\t4 - Loan");
                   Console.WriteLine("\t5 - Back");

                   string option = Console.ReadLine();*/

                MainMenu.DisplayMenu();

                Console.ReadLine();
                while (!exitMenu)
                {
                    bool exitAction = false;
                 
                    while (!exitAction)
                    {
                        string action;

                        switch (menuOption)
                        {
                            case "1":

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
                            case "2":

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

                            case "3":

                                //CD Options
                                Console.WriteLine("CD Options");
                                Console.WriteLine("\t1 - Withdraw");
                                Console.WriteLine("\t2 - Back");
                                Console.WriteLine("\t3 - Exit");

                                action = Console.ReadLine();

                                break;

                            case "4":

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

        }
    }
}
