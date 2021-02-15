using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {

            ///////////////////////////////////////////////////////////////////////////////////////
            //                      Date & Time methods, properties, etc                         //
            ///////////////////////////////////////////////////////////////////////////////////////

            ///////////////////////////////////////////////////////////////////////////////////////
            // when wanting to display Date or Time or DateTime etc
            // DateTime is a data type of type DateTime :-)
            // print out current date and time
            /*
            DateTime myDate = DateTime.Now;
            string strMyDate = myDate.ToString();
            // display result in console and debug window
            CreateOutputAndFinish(strMyDate);
            */

            // convert current date and time to short date string (remove Time and make object into string value)
            /*
            DateTime myDate = DateTime.Now;
            // covert myDate (Date and Time) to string
            string strMyValue = myDate.ToString();
            // convert myDate (Date and Time) to Date only string using built-in method ToShortDateString
            string strMyDate = myDate.ToShortDateString();
            // display result in console and debug window
            CreateOutputAndFinish(strMyDate);
            */

            // convert current date and time to Long date string (remove Time and make object into string value)
            /*
            DateTime myDate = DateTime.Now;
            // covert myDate (Date and Time) to string
            string strMyValue = myDate.ToString();
            // convert myDate (Date and Time) to Date only string using built-in method ToShortDateString
            string strMyDate = myDate.ToLongDateString();
            // display result in console and debug window
            CreateOutputAndFinish(strMyDate);
            */
            // You can do the same thing (ToShort and ToLong) with Time as well

            ///////////////////////////////////////////////////////////////////////////////////////
            // Date Math (adding and subtracting time and date values etc)
            /*
            DateTime myDate = DateTime.Now;
            String strModifiedDate = myDate.AddDays(3).ToLongDateString();
            CreateOutputAndFinish(strModifiedDate);
            */
            // There are a bunch of methods built-in to C# to add and subtract time (minutes, hours seconds, etc) and dates (days, weeks) etc...
            
            // Additionally, you can get parts of the date or time thusly:
            /*
            DateTime myDate = DateTime.Now;
            String strMonthFromMyDate = myDate.Month.ToString();
            CreateOutputAndFinish(strMonthFromMyDate);
            */
            // You can also get things using methods for many things - like DayOfWeek, DayOfYear, etc, etc

            // Overloaded constructuors to build or create/specify a DateTime value etc...
            // code to make my birthday into a DateTime variable type then print it out based on feeding the data type the basic values
            /*
            DateTime myBirthday = new DateTime(1966,2,5);
            CreateOutputAndFinish(myBirthday.ToLongDateString());
            */

            // Compare 2 dates and print out result delta (my age in days)
            /*
            DateTime dtMyBirthday = new DateTime(1966, 2, 5);
            DateTime dtNow = DateTime.Now;
            TimeSpan tsMyAgeDays = dtNow - dtMyBirthday;
            string strMyAgeDays = tsMyAgeDays.TotalDays.ToString();
            // print out my age in days
            CreateOutputAndFinish(strMyAgeDays);
            */

            // Compare 2 dates and print out result delta (my age in years)
            // print out my age in years
            
            DateTime dtMyBirthday = new DateTime(1966, 2, 5);
            DateTime dtNow = DateTime.Now;
            TimeSpan tsMyAgeDays = dtNow - dtMyBirthday;
            double dblMyAgeDays = tsMyAgeDays.TotalDays;
            double dblMyAgeYears = dblMyAgeDays/365;
            string strMyAgeYears = dblMyAgeYears.ToString();
            CreateOutputAndFinish(strMyAgeYears);
            
        }

        private static void CreateOutputAndFinish(string strOutPut)
        {
            // write to the debug output window (seen after code is done running)
            // using Debug class requires a Using statment for using System.Diagnostics
            Debug.WriteLine("");
            Debug.WriteLine("------------");
            Debug.WriteLine("DEBUG OUTPUT FOR TESTING PURPOSES TYPICALLY");
            Debug.WriteLine(strOutPut);
            Debug.WriteLine("------------");
            Debug.WriteLine("");

            // write to the console window
            Console.WriteLine(strOutPut);
            Console.WriteLine();
            Console.WriteLine("Check output window in IDE for more output example");
            Console.WriteLine();
            Console.WriteLine("Press any key to end...");
            Console.ReadKey();
        }
    }
}
