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

            Program.menuOption = Console.ReadLine();
        }

        public string AccountCheck(string option)
        {


            return "Account Check";
        }

        public void SetAction( string option)
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
                    //my the the registry prompts part of the registry class and rather 
                    //than exit to the previous loop, just call the menu again

                default:

                    break;
            }


            
            ;
        }


    }
}
