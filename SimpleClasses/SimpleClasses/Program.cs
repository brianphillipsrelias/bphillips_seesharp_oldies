using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // create instance of the car class object
            Car myNewCar = new Car(); // this is a new instance of an object of the type Car
            Car fooCar = new Car(); // another instance of the car class
            
            // populate it's properties
            myNewCar.Make = "Oldsmobile";
            myNewCar.Model = "Cutlas Supreme";
            myNewCar.Year = 1976;
            myNewCar.Color = "Silver";

            // Console out the output of the values we just assigned to the prperties of the new instance of the Car class object
            Console.WriteLine("{0} {1} {2} {3}", myNewCar.Make, myNewCar.Model, myNewCar.Year, myNewCar.Color);
            Console.WriteLine("");

            //////////////////////////////////////////////////////////////////////////////////////
            /* 2 ways to call a method to get a number for car value:
            1) create a helper method (as we have done below - hlpDetermineMarketValue ) that returns the value somehow
            2) create a class method - which we have created in the class and it is called clsDetermineMarketValue */

            // 1) call a class method to get the car value
            // call the helper method and pass it the car class instance object
            decimal decimalHelperMethodDerivedMarketValueOfCar = hlpDetermineMarketValue(myNewCar);
            // print out car value after returned from helper function
            string strHelperMethodDerivedMarketValueOfCar = string.Format("Car value returned from helper method hlpDetermineMarketValue = {0:C}", decimalHelperMethodDerivedMarketValueOfCar);
            CreateTestOutput(strHelperMethodDerivedMarketValueOfCar);

            // 2) call a class method to get the car value
            // call the class method - notice we do not pass anything we simply ask the class to return the value by calling the method on the class object
            decimal decimalClassMethodDerivedMarketValueOfCar = myNewCar.clsDetermineMarketValue();
            string strClassMethodDerivedMarketValueOfCar = string.Format("Car value returned from class method clsDetermineMarketValue  = {0:C}", decimalClassMethodDerivedMarketValueOfCar);
            // print out car value after returned from helper function
            CreateTestOutput(strClassMethodDerivedMarketValueOfCar);
            //////////////////////////////////////////////////////////////////////////////////////

            /* Console print out (again) the values of the properties for this new class instance (class object) using our built-in method CreateOutputAndFinish
            string strMyNewCarInfo = myNewCar.Year + " " + myNewCar.Make + " " + myNewCar.Model + " - color: " + myNewCar.Color;
            CreateTestOutput(strMyNewCarInfo); */
        }
        private static decimal hlpDetermineMarketValue(Car car)
            // helper method for determining car value that will allow the user to pass in an instance of the car class
            // this is demonstrating that an object instance of the new care class can be used anywhere in code
            // even as an input parameter into a helper method
            {
                decimal carValue = 10000.0M;
                return carValue;
            
                // just hardcoding the value, but someday writing some code that retrieves the valus from the internet or an API would be what is needed
                // that value would then be returned as the car's value variable
            }

        private static void CreateTestOutput(string strOutPut)
        {
            // write to the debug output window (seen after code is done running)
            // using Debug class requires a Using statment for using System.Diagnostics
            Debug.WriteLine("");
            Debug.WriteLine("------------");
            Debug.WriteLine("DEBUG OUTPUGT FOR TESTING PURPOSES TYPICALLY");
            Debug.WriteLine(strOutPut);
            Debug.WriteLine("------------");
            Debug.WriteLine("");

            // write to the console window
            Console.WriteLine("");
            Console.WriteLine(strOutPut);
            Console.WriteLine("");
            Console.WriteLine("Check output window in IDE for more output...");
            Console.WriteLine("");
            Console.WriteLine("Press any key to return...");
            Console.ReadKey();
        }
    }

    class Car
    // create a class that can represent a basic car object type
    {
        // classes can contain code (methods), properties, or other classes - we call all of these: members or members of the class

        // class properties
        // there are many ways to define a property, this is a simple one in a class
        // using tab tab (macro in C#) we type the word Prop and then do tab, tab, which results in a new Property created that looks like this:
        // public int MyProperty { get; set; }
        // we will use that as a foundation to create a new peoperty in our class, then we will make 3 more properties of the car class using this method and populate as we go along...

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        // class method
        // does the same thing as determineMarketValue helper method above
        public decimal clsDetermineMarketValue()
        {
            // again hard-code the value for now
            decimal carValue = 0.00M;

            if (this.Year > 1990) // the "this" keyword allows you access all of the private and public members of a class
                carValue = 10000.00M;
            else
                carValue = 2000.00M;
            return carValue;
        }

    }
}
