using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingScope // understanding the scope of methods, properties, variables, and the classes that contina them etc
{
    class Program
    {
        private static string k = ""; // private field - sort of like a property that is available to all of the memebers of the class
        static void Main(string[] args) //main method of class Program
        {
            string j = ""; //local property (value) since it is inside of the Main method - it is only available inside of Main()
            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);

                if (i == 9)
                {
                    string l = i.ToString();
                    Console.WriteLine("");
                    Console.WriteLine("i = " + l);
                    Console.WriteLine("");
                }
                //Console.WriteLine("i= " + l); // again - get error because l is defined inside of the if  (i == 9) statement etc etc

            }
            // Console.WriteLine(i); // causes error because i at this time is only operting within the for loop abve and is not defined in this context (part of the code)

            // display the i variable via the j property that we defined INSIDE of the method, but outside of the context (For loop)
            Console.WriteLine("Outside of the For loop - " + j);

            // now display the value of i via the k variable, which we establish as a static field (property) available to all of the class
            Console.WriteLine("Outside of the For loop - " + k);

            // call helper method called HelperMethod to return the k value - this works since it was established at the class level, which makes it avaialbel to all of the code in the class
            HalperMethod();

            Car myCar = new Car();
            myCar.DoSomething(); //I can only see this method fron the Car class because it is PUBLIC
            Console.ReadLine();
        }

        static void HalperMethod() //helper method that is accessible to all of the members of the class since it is at the class level
        {
            Console.WriteLine("Value of k from the HelperMethod(): " + k);
        }
    }

    // The class below simply illustrates the notion of encapsulation (where methods are available to the contexts that they are specified for only - using the Private or Public keywords
    // These private and public fields or definitions are defined in C# as "accessibility modifiers" because they modify the accessbility of the code in the class, method, etc...
    class Car
    {
        public void DoSomething()
        {
            Console.WriteLine(helperMethod()); //calls the private method called helperMethod which return the string "Hello World!"
        }

        private string helperMethod() //no consumer of this Car class would ever know that this private method exists and this is bye design
        {
            return "Hello World!";
        }
    }
}
