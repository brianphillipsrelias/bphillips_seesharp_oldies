using ScrapeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrapeClient
{
    class ScrapeClient
    {
        static void Main(string[] args)
        {
            // create a new class object to use
            ScrapeClass myScrapeClassObject = new ScrapeClass();

            // get the string of the webpage using the class method and put it into the strPageText variable
            string strPageText = myScrapeClassObject.ScrapeWebPage("http://www.goodle.com");
            
            CreateTestOutput(strPageText); // call my output method to display what we get back
        }

        private static void CreateTestOutput(string strOutPut)
        {
            // write to the debug output window (seen after code is done running)
            // using Debug class requires a Using statment for using System.Diagnostics
            System.Diagnostics.Debug.WriteLine("");
            System.Diagnostics.Debug.WriteLine("------------");
            System.Diagnostics.Debug.WriteLine("DEBUG OUTPUT FOR TESTING PURPOSES...");
            System.Diagnostics.Debug.WriteLine(strOutPut);
            System.Diagnostics.Debug.WriteLine("------------");
            System.Diagnostics.Debug.WriteLine("");

            // write to the console window
            Console.WriteLine("");
            Console.WriteLine("output: ");
            Console.WriteLine(strOutPut);
            Console.WriteLine("");
            Console.WriteLine("Check output window in IDE for more output - Press any key to return...");
            Console.ReadKey();
        }
    }
}
