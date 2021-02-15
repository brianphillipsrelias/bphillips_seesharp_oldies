using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        ///////////////////////////////////////////////////////////////////////////////////////
        // Main method (default starting point for all C# programs, etc...
        static void Main(string[] args)
        {

            ///////////////////////////////////////////////////////////////////////////////////////
            //                      CHARACTER ESCAPE SEQUENCES IN STRINGS                        //
            ///////////////////////////////////////////////////////////////////////////////////////

            ///////////////////////////////////////////////////////////////////////////////////////
            // when wanting to display a backslash in a string, you must use 2 for 1
            // because a single one results in error (since backslash is a special character in C#
            // \\ :=)

            // string myString = "Go to your c:\\ drive";
            // CreateOutputAndFinish(myString);
            
            ///////////////////////////////////////////////////////////////////////////////////////
            // double quotes inside a literal string - use ESC character which is the backslash

            // string myString = "My \"so called\" life";

            ///////////////////////////////////////////////////////////////////////////////////////
            // line return

            // string myString = "What if I need a:\nnew line";

            // There are many of these. The most common can be found listedin various places on the internet like here:
            // https://blogs.msdn.microsoft.com/csharpfaq/2004/03/12/what-character-escape-sequences-are-available/

            /*
            \' – single quote, needed for character literals
            \" – double quote, needed for string literals
            \\ – backslash
            \0 – Unicode character 0
            \a – Alert (character 7)
            \b – Backspace (character 8)
            \f – Form feed (character 12)
            \n – New line (character 10)
            \r – Carriage return (character 13)
            \t – Horizontal tab (character 9)
            \v – Vertical quote (character 11)
            \uxxxx – Unicode escape sequence for character with hex value xxxx
            \xn[n][n][n] – Unicode escape sequence for character with hex value nnnn (variable length version of \uxxxx)
            \Uxxxxxxxx – Unicode escape sequence for character with hex value xxxxxxxx (for generating surrogates)
            */

            ///////////////////////////////////////////////////////////////////////////////////////
            //                  Substitiue or merge strings into other strings                   //
            ///////////////////////////////////////////////////////////////////////////////////////

            ///////////////////////////////////////////////////////////////////////////////////////
            // the string.format method allows you to, among other things, to merge strings into other strings using a template or boilerplate type structure
            // the following example is instructing the string.format property to populate the target of the string format (0) with the word Bonzai

            // string myString = string.Format("{0}!", "Bonzai");
            // CreateOutputAndFinish(myString);

            ///////////////////////////////////////////////////////////////////////////////////////
            // a more complex sample building on the simple 0 base

            // string myString = string.Format("Make: {0} Model: {1}", "BMW", "760li");
            // CreateOutputAndFinish(myString);

            ///////////////////////////////////////////////////////////////////////////////////////
            // crazy pointless example

            // string myString = string.Format("Lets list some fruits: {0} {1} {2} {3}", "banana", "apple", "orange", "grapefruit");
            // CreateOutputAndFinish(myString);

            ///////////////////////////////////////////////////////////////////////////////////////
            // the main use for string.format though is for formatting numbers...

            // "{0:C}" is the format (currency), 123.45 is the value we are formatting
            // string myString = string.Format("{0:C}", 123.45);
            // CreateOutputAndFinish(myString);

            ///////////////////////////////////////////////////////////////////////////////////////
            // format a long number for easier reading - resulting output is: 12,345,678,910,111,213.00
            // string myString = string.Format("{0:N}", 12345678910111213);
            // CreateOutputAndFinish(myString);

            ///////////////////////////////////////////////////////////////////////////////////////
            // percentage
            // string myString = string.Format("{0:P}",.12345);
            // CreateOutputAndFinish(myString);

            ///////////////////////////////////////////////////////////////////////////////////////
            // custom string formats (uses # sign for masking numbers)
            // string myString = string.Format("Phone Number: {0:(###)###-####}",1234567890);
            // CreateOutputAndFinish(myString);

            // There are many number formats that can be used by string.format. For a comprehensive list, go here:
            // http://is.gd/string_format

            
            ///////////////////////////////////////////////////////////////////////////////////////
            //                     String concantenation operator                                //
            ///////////////////////////////////////////////////////////////////////////////////////
            
            /*
            string myString = "";
            for (int i = 0; i < 100; i++)
            {
                myString = myString + "--" + i.ToString();
            }
            CreateOutputAndFinish(myString);
            */

            // another way using += operator (which says the same as x = x + y - take my existing string and appened whatever I specify next to that string
            /*
            string myString = "";

            for (int i = 0; i < 100; i++)
            {
                //myString = myString + "--" + i.ToString();
                myString += "--" + i.ToString();
            }

            CreateOutputAndFinish(myString);
            */

            ///////////////////////////////////////////////////////////////////////////////////////
            //            StringBuilder class (built-in class) - used for concatentation         //
            ///////////////////////////////////////////////////////////////////////////////////////
            
            // Use StringBuilder class to do the same as above (faster performance)
            /*
            StringBuilder myString = new StringBuilder();
            for (int i = 1; i < 100; i++)
            {
                myString.Append(i);
                if (i != 99)   // avoid trailing -- on last iteration
                myString.Append("--");
            }
            CreateOutputAndFinish(myString.ToString());
            */

            ///////////////////////////////////////////////////////////////////////////////////////
            //                  built-in string methods used to manipulate strings...            //
            ///////////////////////////////////////////////////////////////////////////////////////

            ///////////////////////////////////////////////////////////////////////////////////////
            // using built-in string methods like SubString, ToUpper, Trim, etc
            
            // .SubString method pulls a string from inside another string -  inputs are where to start in the string and how many chars to include
            // .Replace Method replaces characters specified etc
            
            /*
            string myString = "Hey Hey Mama I like the way you move";
            string mySubString = myString.Substring(13, 6);
            string myDashedString = myString.Replace(" ", "--");

            // write out the original, substring, then string with the replacements and then end the program
            Console.WriteLine(myString);
            Console.WriteLine(" ");
            Console.WriteLine(mySubString);
            Console.WriteLine(" ");
            Console.WriteLine(myDashedString);
            Console.WriteLine(" ");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            */

            // There are many other built-in string methods provided by C# - just like in VB etc...
            // Another one is ToUpper()
            /*
            string myLowerCaseString = "Hey Hey Mama I like the way you move";
            string myString = myLowerCaseString.ToUpper();
            CreateOutputAndFinish(myString);
            */

            ///////////////////////////////////////////////////////////////////////////////////////
            // using String.Format to report the untrimmed and trimmed length of a string
            // NOTE the use of CHAINED COMMANDS (adding .Length to .Trim() since it returns a string in the example
            // - this is important use in C# - chained commands are vital

            /* string myString = "  Hey Hey Mama I like the way you move  ";
            myString = string.Format("Length Before: {0} -- After: {1}", myString.Length, myString.Trim().Length);
            CreateOutputAndFinish(myString);
            */
        }

        ///////////////////////////////////////////////////////////////////////////////////////
        // Void method to create the output both in the console window and in the output window (which requires reference to System.Diagnostics)
        // then end the code

        private static void CreateOutputAndFinish(string strOutPut)
        {
            // write to the debug output window (seen after code is done running)
            // using Debug class requires a Using statment for using System.Diagnostics
            Debug.WriteLine("");
            Debug.WriteLine("------------");
            Debug.WriteLine("DEBUG OUTPUT FOR TESTING PURPOSES");
            Debug.WriteLine(strOutPut);
            Debug.WriteLine("------------");
            Debug.WriteLine("");
            
            // write to the console window
            Console.WriteLine(strOutPut.ToString());
            Console.WriteLine();
            Console.WriteLine("Check output window in IDE for more output example");
            Console.WriteLine();
            Console.WriteLine("Press any key to end...");
            Console.ReadKey();
        }
    }
}
