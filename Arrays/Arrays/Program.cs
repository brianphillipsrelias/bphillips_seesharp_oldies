using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////////////////////////////////////////////////////////
            // Arrays
            ///////////////////////////////////////////////////////////////////////////////////////

            // NOTES:
            // - all arrays in C# default to starting with 0
            // - arrays cannot be changed in size after they have been defined in code

            ///////////////////////////////////////////////////////////////////////////////////////
            // very basic array integers
            /*
            int[] arrayNumbers = new int[5];

            arrayNumbers[0] = 4;
            arrayNumbers[1] = 8;
            arrayNumbers[2] = 15;
            arrayNumbers[3] = 16;
            arrayNumbers[4] = 23;

            Console.WriteLine(arrayNumbers[1].ToString());
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            */

            ///////////////////////////////////////////////////////////////////////////////////////
            // simpler version of very basic array integers
            // the arrayNumbers array does not have its size specified in this example, which is OK - C# simply makes the array of N size once it see what is in it
            // byte[] blah = new byte[] {8};
            /*
            int[] arrayNumbers = new int[] {4,8,15,16,23,42};

            Console.WriteLine(arrayNumbers[1].ToString());
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            */

            ///////////////////////////////////////////////////////////////////////////////////////
            // basic array strings
            /*
            string[] arrayStrings = new string[5] {"Apple", "Orange", "Banana", "Peach", "Plum"};

            Console.WriteLine(arrayStrings[3]);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            */

            ///////////////////////////////////////////////////////////////////////////////////////
            // using foreach against the string array
            /*
            string[] arrayNames = new string[4] {"Eddie", "Alex", "Michael", "David Lee"};

            foreach (string strName in arrayNames)
            {
                {
                    Console.WriteLine(strName);
                }
                
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            */

            ///////////////////////////////////////////////////////////////////////////////////////
            // using foreach against the string array and determining if the array contains a particular string
            /*
            string[] arrayFruits = new string[5] {"Apple", "Orange", "Banana", "Peach", "Plum"};

            foreach (string arrayitemFruit in arrayFruits)
            {
                if (arrayitemFruit == "Banana")
                {
                    Console.WriteLine(arrayitemFruit);
                    break;
                }
                
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            */

            ///////////////////////////////////////////////////////////////////////////////////////
            // using charArray to walk through all chracters in an array of characters
            // so using a new data type char[] is an array of chars etc like string[] or int[] or byte[]
            
            string strZig = "You can get what you want out of life if " +
                    "you help enough other people get what they want out of life";

            char[] charArray = strZig.ToCharArray();
            Array.Reverse(charArray); //reverses the order of the chars in the array
            
            // now write out the entire array of characters after it has been reversed
            foreach (char zigChar in charArray)
                Console.Write(zigChar);

            // WriteLine writes each on a new line, Console.Write just writes them one after the other...
            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            
        }
    }
}
