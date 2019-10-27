using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp
{
    class Register
    {
        public Customer newCust;

        public static void custCheck()
        {
            if( Program.currentCustomer is null)
            {
                Console.WriteLine("---------------------------\r");
                Console.WriteLine("Please Type your First Name\r");
                Console.WriteLine("---------------------------\n");

                //Replace This method of setting with validation
                string firstName = Console.ReadLine();

                Program.fName = firstName;

                Console.WriteLine("---------------------------\r");
                Console.WriteLine("Please Type your Last Name\r");
                Console.WriteLine("---------------------------\n");

                //Replace This method of setting with validation
                string lastName = Console.ReadLine();

                Program.lName = lastName;

                Program.currentCustomer = new Customer(Program.fName, Program.lName);


                Console.WriteLine($"Thank you {firstName} {lastName}");

                MainMenu.DisplayMenu();

            }
            else
            {
                MainMenu.DisplayMenu();
            }
        }
        public static void WelcomePrompt()
        {
            Console.WriteLine("---------------------------\r");
            Console.WriteLine("Welcome To Your Banking App\r");
            Console.WriteLine("---------------------------\n");
            Console.WriteLine("--Press Enter to Continue--\n");

            string logOn = Console.ReadLine();
            Register.custCheck();
 
        }

        public Customer RegisterCustomer (string firstn , string lastn)
        {

            Customer newCust = new Customer(firstn, lastn);

            return newCust ;
        }
    }
}
