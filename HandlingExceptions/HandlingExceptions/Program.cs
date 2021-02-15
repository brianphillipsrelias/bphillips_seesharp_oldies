using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptions
{
    class Program
    {
        // Main method
        static void Main(string[] args)
        {
            try
            {
                string strContent = File.ReadAllText(@"C:\home\brian\DEV\SeeSharp\LearningC#\Lessons from Bob Tabor (C# Fundamentals for Absolute Beginners)\Lesson_22\Example.txt");
                Console.WriteLine(strContent); Console.WriteLine("");
            }
            catch (FileNotFoundException ex)
            {
                // Console.WriteLine("There was a problem...(FileNotFoundException)");
                // Console.WriteLine(ex.Message);
                // Console.ReadLine();
                ErrorCatchAndRelease(ex);
            }
            catch (DirectoryNotFoundException ex)
            {
                // Console.WriteLine("There was a problem...(DirectoryNotFoundException)");
                // Console.WriteLine(ex.Message);
                // Console.ReadLine();
                ErrorCatchAndRelease(ex);
            }
            catch (Exception ex)
            {
                // Console.WriteLine("There was a problem...(general exception)");
                // Console.WriteLine(ex.Message);
                // Console.ReadLine();
                ErrorCatchAndRelease(ex);
            }
            // code to finalize the try-ctach - this code always runs - use it to set objects to null, close dtatabase connections, etc...
            finally
            {
                Console.WriteLine(""); Console.WriteLine("Closing application now. Press any key to end..."); Console.ReadKey();
            }

        }

        // method to evalutate the exception and report the error to the user before the system does
        static void ErrorCatchAndRelease(Exception exException)
        {
            // string strExceptionMessage = exException.Message.ToString();
            string strException = exException.GetType().ToString();
            Console.WriteLine(exException.Message);
            
            if (strException == "System.IO.FileNotFoundException")
            {
                Console.WriteLine("Please make sure the file exists in the specified path...");
            }
            else if (strException == "System.IO.DirectoryNotFoundException")
            {
                Console.WriteLine("Please make sure the specified directory exists...");
            }
            else
            {
                Console.WriteLine("There was a general problem...");
            }
        }
    }
}
