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

                Register.WelcomePrompt();

                
                //Console.WriteLine("Welcome {0} {1} ", currentCustomer.firstName, currentCustomer.lastName  );

                //MainMenu.DisplayMenu();

            }

        }
    }
}
