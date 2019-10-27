using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankingApp
{

    class MainMenu
    {
        public static List<Account> mMenuAccounts = new List<Account>();

        public static Account tempAccount {get;set;}

        public string menuOption { get; set; }


        public static void DisplayMenu()
        {
            Console.WriteLine("Choose an Account from the following list:");
            Console.WriteLine("\t - Checking");
            Console.WriteLine("\t - Business");
            Console.WriteLine("\t - CD");
            Console.WriteLine("\t - Loan");
            Console.WriteLine("\t - Open Account");
            Console.WriteLine("\t - Exit");

            var total = mMenuAccounts.Count();
            
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

                    Console.WriteLine("What will be your initial deposit for the Checking Account?");

                    int checkingDeposit = Convert.ToInt32(Console.ReadLine());

                     MainMenu.tempAccount = new Checking(firstName, lastName, account, checkingDeposit) { };

                    Program.custAccounts.Add((Account)tempAccount);
                    MainMenu.mMenuAccounts.Add((Account)tempAccount);
                    Console.WriteLine("Thank you for your business.");
                    MainMenu.DisplayMenu();

                    break;
                case "Business":

                    Console.WriteLine("What will be your initial deposit for the Business Account?");

                    int businessDeposit = Convert.ToInt32(Console.ReadLine());

                    MainMenu.tempAccount = new Business(firstName, lastName, account, businessDeposit) { };

                    Program.custAccounts.Add((Account)tempAccount);
                    MainMenu.mMenuAccounts.Add((Account)tempAccount);
                    Console.WriteLine("Thank you for your business.");
                    MainMenu.DisplayMenu();

                    break;
                case "CD":
                    Console.WriteLine("For what number of months? Please type a number.");

                    int cdMaturity = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("What will be your deposity for the {0} month term?", cdMaturity);

                    int cdDeposit = Convert.ToInt32(Console.ReadLine());

                    MainMenu.tempAccount = new CD(firstName, lastName, account, cdMaturity, cdDeposit) { };

                    Program.custAccounts.Add((Account)tempAccount);
                    MainMenu.mMenuAccounts.Add((Account)tempAccount);
                    Console.WriteLine("Thank you for your business.");
                    MainMenu.DisplayMenu();

                    break;

                case "Loan":

                    Console.WriteLine("Please enter a desired amount for your new Loan Account.");

                    int loan = Convert.ToInt32(Console.ReadLine());

                    MainMenu.tempAccount = new Loan(firstName, lastName, account, loan) { };

                    Program.custAccounts.Add((Account)tempAccount);
                    MainMenu.mMenuAccounts.Add((Account)tempAccount);
                    Console.WriteLine("Thank you for your business.");
                    MainMenu.DisplayMenu();


                    break;

                default:

                    MainMenu.DisplayMenu();
                    break;

            }
             

        }

        public static void AccountCheck(string fname , string lname, string account)
        {
            
               
                var mMenuAccounts = Program.custAccounts.Where(c => (c.firstName == fname) && (c.lastName == lname) && (c.accountType == account)).ToList<Account>();
           
                if (!mMenuAccounts.Any())
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
                else
                {
                    ActionMenu.DisplayAccounts(mMenuAccounts);

                }
 
            }


        public static void ProcessAction(string option)
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
                    AccountCheck(Program.fName, Program.lName, option);
                    //CD Options Pointer
                    Program.menuOption = option;
                    break;

                case "Loan":
                    //Loan
                    AccountCheck(Program.fName, Program.lName, option);
                    //Loan Options Pointer
                    Program.menuOption = option;
                    break;
                case "Open Account":
                    //To Open Account
                    Console.WriteLine("Which of the following account types would you like to open?");
                    Console.WriteLine("\t - Checking");
                    Console.WriteLine("\t - Business");
                    Console.WriteLine("\t - CD");
                    Console.WriteLine("\t - Loan");
                    Console.WriteLine("\t - Exit");
                    Console.WriteLine("Please type your selection");

                    var openType = Console.ReadLine();

                    if (openType != "Exit")
                    {
                        MainMenu.CreateAccount(Program.fName, Program.lName, openType);
                    }
                    else
                    {
                        MainMenu.DisplayMenu();
                    }

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
