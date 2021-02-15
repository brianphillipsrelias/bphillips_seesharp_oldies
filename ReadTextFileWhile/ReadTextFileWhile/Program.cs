using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadTextFileWhile
{
    class Program
    {
        ///////////////////////////////////////////////////////////////////////////////////////
        // Main method (default starting point for all C# programs, etc...
        static void Main(string[] args)
        {
            ///////////////////////////////////////////////////////////////////////////////////////
            // read from values.txt until we rech the end (while the current line is not NULL
            StreamReader myReader = new System.IO.StreamReader("values.txt");
            string strLine = "";

            while (strLine !=null)
            {
                strLine = myReader.ReadLine();
                //if (strLine != null) // not needed - not sure why example includes this...
                Console.WriteLine(strLine);
            }

            ///////////////////////////////////////////////////////////////////////////////////////
            // close the myReader object variable in order to be memory efficient then end the program...
            myReader.Close();

            Console.WriteLine(" ");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
