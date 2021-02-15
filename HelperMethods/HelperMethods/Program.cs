using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethods
{
    class Program
    {
        ///////////////////////////////////////////////////////////////////////////////////////
        // Main method (default starting point for all C# programs, etc...
        static void Main(string[] args)
        {
            ///////////////////////////////////////////////////////////////////////////////////////
            // call helper method HelloWorldGetString
            string myValueFull = HelloWorldGetString();
            Console.WriteLine(myValueFull);
            Console.ReadKey();

            ///////////////////////////////////////////////////////////////////////////////////////
            // call helper method HelloWorldGetString (overload) which passes a string to the method and gets in return a string value
            // combined with the string that was passed
            string myValueGetFullStringFromMethod = HelloWorldGetString("world!");
            string myValueComplete = myValueGetFullStringFromMethod + " (end of string returned via method and combined with caller input to form entire string)";
            Console.WriteLine(myValueComplete);
            Console.ReadKey();

            ///////////////////////////////////////////////////////////////////////////////////////
            // call a void method just for practice
            sampleVoidMethod();

            ///////////////////////////////////////////////////////////////////////////////////////
            // signify that the code is ending...
            Console.WriteLine("end of program");
            Console.ReadKey();
            
        }
        ///////////////////////////////////////////////////////////////////////////////////////
        // below is a private method that can be called by anything in the same class since it is private
        // it returns a string 
        private static string HelloWorldGetString()
        {
            // do stuff here then retun something etc
            return "Hello World! (complete string returned from Method with no input";
        }
        
        ///////////////////////////////////////////////////////////////////////////////////////
        // same  very simple example method below but one that accepts a string as input and returns that string added onto "Hello " as the return value (string)
        // this is an overloaded version of the previous method HelloWorldGetString (which accepts a string paramter)- no error occurs even though they have the same name
        // because they are different in terms of their signature (what type of data they accept etc)
        private static string HelloWorldGetString(string name)
        {
            // Use string replacement formula ({0}) to drop in the passed in value
            // return String.Format("Hello, {0}", name);
            // OR - simply do:
            return "Hello " + name;
        }
        ///////////////////////////////////////////////////////////////////////////////////////
        // void methods execute whatever code is inside of them but do not return anything
        private static void sampleVoidMethod()
        {
            Console.WriteLine("Void method called & executed...");
            Console.ReadKey();
        }

        ///////////////////////////////////////////////////////////////////////////////////////
        // Void method to create the output both in the console window and in the output window (which requires reference to System.Diagnostics)
        // then end the code
        private static void CreateOutputAndFinish(string strOutPut)
        {
            Debug.WriteLine(strOutPut);
            Console.WriteLine(strOutPut);
            Console.WriteLine("Press any key to end...");
            Console.ReadKey();
        }
    }
}
