using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsExpressionsStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // basic operators, keywords, etc - a NON exhaustive list
            
            int x, y, a, b;

            // assignment operator
            x = 3;
            y = 2;
            a = 1;
            b = 0;

            // comparison operators (equality, greater than, less then, etc
            if (x == y)
            {
                // do stuff
            }
            // Greater than operator
            if (x > y)
            {
                // do stuff
            }
            // conditional operators

            if ((x > y) && (a > b))
            {
                // do stuff
            }
            if ((x > y) || (a > b))
            {
                // do stuff
            }

            // inline conditional operator
            string message = (x == 1) ? "Car" : "Boat";

            //etc etc etc

        }
    }
}
