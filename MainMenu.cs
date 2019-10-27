using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankingApp
{

    class MainMenu
    {
        public List<Account> mMenuAccounts = new List<Account>();

        public Account tempAccount {get;set;}

        public string menuOption { get; set; }


        public static void DisplayMenu()
        {
            Console.WriteLine("Choose an Account from the following list:");
            Console.WriteLine("\t - Checking");
            Console.WriteLine("\t - Business");
            Console.WriteLine("\t - CD");
            Console.WriteLine("\t - Loan");
            Console.WriteLine("\t - Exit");

            ProcessAction(Console.ReadLine());
        }

        public static void ExitApp()
        {
            Register.WelcomePrompt();

        }

        public static void CreateAccount(string fname, string lname, string account)
        {

            string firstName = fname;
            string lastName = lname;
           switch (account)
            {
                case "Checking":

                  

                    break;
                case "Business":

                    break;
                case "CD":
                    Console.WriteLine("For what number of months? Please type a number.");

                    int cdMaturity = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("What will be your deposity for the {0} month term?", cdMaturity);

                    int cdDeposit = Convert.ToInt32(Console.ReadLine());



                    CD tempAccount = new CD(firstName, lastName, account, cdMaturity, cdDeposit) { };

                    Console.WriteLine("{0}", tempAccount.firstName);
                    Program.custAccounts.Add((Account)tempAccount);

                    Console.WriteLine("Thank you for your business.");

                    break;

                case "Loan":

                    break;

                default:

                    MainMenu.DisplayMenu();
                    break;

            }
             

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
                    ActionMenu.DisplayAccounts(mMenuAccounts);


                    //ActionMenu.DisplayActionMenu(mMenuAccounts);
                }

               
            }
            catch ( Exception ex)
            {
                /*var debaccount = Program.custAccounts.First();
                Console.WriteLine("{0}", debaccount);*/
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
                    AccountCheck(Program.fName, Program.lName, option);
                    //Checking Options Pointer
                    Program.menuOption = option;
                    break;

                case "Business":
                    //Business
                    AccountCheck(Program.fName, Program.lName, option);
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
                    AccountCheck(Program.fName, Program.lName, option);
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
