using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualityExamples
{
    class Equality
    {
        static void Main()
        {
            // Numeric equality: True
            Console.WriteLine((2 + 2) == 4);
            Console.ReadLine();

            // Reference equality: different objects, 
            // same boxed value: False.
            object s = 1;
            object t = 1;
            Console.WriteLine(s == t);
            Console.ReadLine();

            // Define some strings:
            string a = "hello";
            string b = String.Copy(a);
            string c = "hello";
            // Compare string values of a constant and an instance: True
            Console.WriteLine(a == b);
            Console.ReadLine();

            // Compare string references; 
            // a is a constant but b is an instance: False.
            Console.WriteLine((object)a == (object)b);
            Console.ReadLine();

            // Compare string references, both constants 
            // have the same value, so string interning
            // points to same reference: True.
            Console.WriteLine((object)a == (object)c);
            Console.ReadLine();
        }
    }
}
