using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////////////////////////////////////////////////////////////
            // using If statements to control flow
            /*
            Console.WriteLine("Would you prefer what is behind door number 1, 2, or 3?");
            string userValue = Console.ReadLine();
            if (userValue == "1")
            {
                Console.WriteLine("You won a new car!");
                Console.ReadLine();
            }
            else if (userValue == "2")
            {
                Console.WriteLine("You won a new boat!");
                Console.ReadLine();
            }
            else if (userValue == "3")
            {
                Console.WriteLine("You won a new cat!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You did not enter a valid number");
                Console.Clear();
                Console.WriteLine("press any key to exit");
                Console.Beep();
                Console.ReadLine();
            }
            */

            /////////////////////////////////////////////////////////////////////////////////////////////
            // refactored version of using if statements to control flow using a variable for the retun value
            /*
            Console.WriteLine("Would you prefer what is behind door number 1, 2, or 3?");
            string userValueRefactored = Console.ReadLine();
            string strMessage = "";
            if (userValue == "1")
            {
                strMessage = "You won a new car!";
            }
            else if (userValueRefactored == "2")
            {
                strMessage = "You won a new boat!";
            }
            else if (userValueRefactored == "3")
            {
                strMessage = "You won a new cat!";
            }
            else
            {
                strMessage = "You did not enter a valid number";
            }
            Console.WriteLine(strMessage);
            Console.ReadLine();
            */

            /////////////////////////////////////////////////////////////////////////////////////////////
            // version of using if statements to control flow using a variable for the retun value
            // further refactored below and more simplified example of the same code, not using the curly brackets etc...
            // NOTE: you can only omit the curly craces when the IF statement is followed by a single line of code as is below
            /*
            Console.WriteLine("Would you prefer what is behind door number 1, 2, or 3?");
            string userValueRefactored = Console.ReadLine();
            string strMessage = "";
            if (userValueRefactored == "1") strMessage = "You won a new car!";
            else if (userValueRefactored == "2") strMessage = "You won a new boat!";
            else if (userValueRefactored == "3") strMessage = "You won a new cat!";
            else strMessage = "You did not enter a valid number";
            Console.WriteLine(strMessage);
            Console.ReadLine();
            */

            /////////////////////////////////////////////////////////////////////////////////////////////
            // comparison syntax & passing variables into WriteLine method
            /*
            Console.WriteLine("Would you prefer what is behind door number 1, 2, or 3?");
            string userValue = Console.ReadLine();
            string strMessage = (userValue == "1") ? "boat" : "strand of lint"; //// ? is used for comparison while : is used for "else"
            Console.WriteLine("You won a {0}", strMessage); //// this format of the WriteLine method is used in order to pass in data or variables for the output
            // Console.WriteLine("You won a {0} {1}", strMessage, userValue); //// and you can add addiitional variables/inputs for the WriteLine method etc
            Console.ReadLine();
            */
        }
    }
}
