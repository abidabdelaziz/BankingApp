using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankingApp
{

    class MainMenu
    {
        public List<Account> mMenuAccounts = new List<Account>();

        public string menuOption { get; set; }


        public static void DisplayMenu()
        {
            Console.WriteLine("Choose an Account from the following list:");
            Console.WriteLine("\t - Checking");
            Console.WriteLine("\t - Business");
            Console.WriteLine("\t - CD");
            Console.WriteLine("\t - Loan");
            Console.WriteLine("\t - Exit");


            Console.WriteLine("{0}", Program.custAccounts.Count);

            ProcessAction(Console.ReadLine());

           // Program.menuOption = Console.ReadLine();
        }

        public static void ExitApp()
        {
            Register.WelcomePrompt();

        }

        public static void CreateAccount(string fname, string lname, string account)
        {

        }

        public static void AccountCheck(string fname , string lname, string account)
        {
            try
            {
               
                var mMenuAccounts = Program.custAccounts.Where(c => (c.firstName == fname) && (c.lastName == lname) && (c.accountType == account)).ToList<Account>();

                if (!mMenuAccounts.Any())
                {
                    //unhandled exception
                    throw new Exception("Exception Thrown");
                }
                else
                {
                    Console.WriteLine(" Create Account ");
                }

               
            }
            catch ( SystemException)
            {
                Console.WriteLine("No Such Account exists in your Name ");
                Console.WriteLine("Create Account of Type Accessed? ( Yes or No )");

                var reply = Console.ReadLine();

                if (reply == "Yes")
                {
                    CreateAccount(fname, lname, account);
                }
                else
                {
                    DisplayMenu();
                }
              
            
            }
            
          
        }


        public static void ProcessAction( string option)
        {

            switch (option)
            {
                case "Checking":
                    //Checking
                    //Check for Account
                    //Checking Options Pointer
                    Program.menuOption = option;
                    break;

                case "Business":
                    //Business
                    //Check for Account
                    //Business Options Pointer 
                    Program.menuOption = option;
                    break;

                case "CD":
                    //CD
                    //Check for Account
                    AccountCheck( Program.fName,  Program.lName,  option);
                    //CD Options Pointer
                    Program.menuOption = option;
                    break;

                case "Loan":
                    //Loan
                    //Check for Account
                    //Loan Options Pointer
                    Program.menuOption = option;
                    break;

                case "Exit":
                
                    Register.WelcomePrompt();
                    break;

                default:

                    break;
            }


            
            ;
        }


    }
}
