using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////////////////////////////////////////////////////////////
            // simple variables
            /*
            int x;
            int y;
            x=7;
            y=x+3;
            Console.WriteLine(y);
            Console.ReadLine();
            */

            /////////////////////////////////////////////////////////////////////////////////////////////
            // simple string variables using string, direct assigment, and var
            /*
            string myFirstName;
            myFirstName = "Brian";
            Console.WriteLine(myFirstName);
            Console.ReadLine();
            
            // simpler code for same thing:
            string myfirstname = "Brian (simpler code)";
            Console.WriteLine(myfirstname);
            Console.ReadLine();
            */

            /////////////////////////////////////////////////////////////////////////////////////////////
            // using var keyword which is the MOST simple data type since the compiler will figure it out based on what data you assign to it...
            /*
            var myFirstName = "Brian (using var)";
            Console.WriteLine(myFirstName);
            Console.ReadLine();
            */

            /////////////////////////////////////////////////////////////////////////////////////////////
            // converting data types
            // implicit conversion
            /*
            int x = 7;
            string y = "Brian";
            string myFirstTry = x + y; //implicit conversion by C# - // what is really happening is string myFirstTry =x.ToString() + y;
            Console.WriteLine(myFirstTry);
            Console.ReadLine();
            // this is all not really recommended typically - it is ALWAYS safer to explicitly convert
            */

            /////////////////////////////////////////////////////////////////////////////////////////////
            // explicit data conversion
            /*
            int x = 7;
            string y = "5";
            string mySecondTry = x + y;
            Console.WriteLine(mySecondTry);
            // results in output = "75"
            Console.ReadLine();
            */

            /////////////////////////////////////////////////////////////////////////////////////////////
            // read user input from the console window
            /*
            Console.WriteLine("Please type something and press the Enter key:");
            string userValue;
            userValue = Console.ReadLine();
            Console.WriteLine("You typed: " + userValue);
            Console.ReadLine();
            */
        }
    }
}
