using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForIterations
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////////////////////////////////////////////////////////
            // For iterations samples
            // ++ is referred to as the increment operator; the same thing as i=i+1, etc...
            /* The logic of the for is as follows: 
            a) this is the variable and its value;
            b) while the variable meets the follow condition;
            c) then iterate incrementally as in i=i+1 and do whatever is inside of the curly brackets below
            */
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i.ToString());
            }
            // int x = i;
            Console.ReadLine();
            
            ///////////////////////////////////////////////////////////////////////////////////////
            // another version:
            /*
            for (int forCounter = 0; forCounter < 10; forCounter++)
            {
                Console.WriteLine(forCounter.ToString());
            }
            Console.ReadLine();
            */

            ///////////////////////////////////////////////////////////////////////////////////////
            // For iterations samples
            /* for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i.ToString());

                if (i == 7) //test to see when the variable is equal to 7
                {
                    Console.WriteLine("found #7");
                    break;
                }
            }
            */

            ///////////////////////////////////////////////////////////////////////////////////////
            // Using the "code snippet" feature to create another loop. To create the below code we simply put the IP on a new line and type "for" then
            // hit tab twice - this creates a new loop structure with all of the existing variables so I can easily add a new one...
            /*
            for (int iReplacedByAVariableIChoose = 0; iReplacedByAVariableIChoose < 12; iReplacedByAVariableIChoose++)
            {
                Console.WriteLine(iReplacedByAVariableIChoose);
            }
            
            // Console.ReadLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            */
        }
    }
}
