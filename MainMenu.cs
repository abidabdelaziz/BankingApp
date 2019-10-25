using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp
{
    class MainMenu
    {
        public string menuOption { get; set; }


        public static void DisplayMenu()
        {
            Console.WriteLine("Choose an Account from the following list:");
            Console.WriteLine("\t1 - Checking");
            Console.WriteLine("\t2 - Business");
            Console.WriteLine("\t3 - CD");
            Console.WriteLine("\t4 - Loan");
            Console.WriteLine("\t5 - Exit");


            Console.WriteLine("{0}", Program.custAccounts.Count);

            ProcessAction(Console.ReadLine());

           // Program.menuOption = Console.ReadLine();
        }

        public static void ExitApp()
        {
            Register.WelcomePrompt();

        }

        public string AccountCheck(string option)
        {


            return "Account Check";
        }

        public static void ProcessAction( string option)
        {

            switch (option)
            {
                case "1":
                    //Checking
                    //Create And Store Object
                    //Checking Options Pointer
                    Program.menuOption = option;
                    break;

                case "2":
                    //Business
                    //Create And Store Object
                    //Business Options Pointer 
                    Program.menuOption = option;
                    break;

                case "3":
                    //CD
                    //Create And Store Object
                    //CD Options Pointer
                    Program.menuOption = option;
                    break;

                case "4":
                    //Loan
                    //Create Initial Deposit And Store Object
                    //Loan Options Pointer
                    Program.menuOption = option;
                    break;

                case "5":
                    Console.WriteLine("herro");
                    Register.WelcomePrompt();
                    break;

                default:

                    break;
            }


            
            ;
        }


    }
}
