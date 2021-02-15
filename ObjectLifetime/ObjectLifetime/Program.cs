using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Exercises in creating, manipulating, and destroying object references, etc
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // create new instance of class object then populate it's properties
            Car myCar = new Car(); // basically calling Car() to create a new instance of a Car class object
            myCar.Make = "Oldsmobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1986;
            myCar.Color = "Silver";

            /* create a reference to the new myCar class object (adds 1 to the reference count in C#)
            does not use the constructor since it is a reference to the first already constructed class object */
            Car myOtherCar = myCar;
         
            // change a property value of the new class object then display the properties of the new referenced class object (myOtherCar)
            myOtherCar.Make = "Mercedes-Benz";
            string strmyOtherCarProperties = string.Format("myOtherCar properties: {0} {1} {2} {3}", myOtherCar.Make, myOtherCar.Model, myOtherCar.Year, myOtherCar.Color);
            CreateTestOutput(strmyOtherCarProperties);

            /* now we display the property values of the original class object - note they are the same since mOtherCar points to the same class object
            - it i imply a reference to the same class object */
            string strmyCarProperties = string.Format("myCar properties: {0} {1} {2} {3}", myCar.Make, myCar.Model, myCar.Year, myCar.Color);
            CreateTestOutput(strmyCarProperties);

            // call overloaded method and pass variables then display properties
            Car myThirdCar = new Car("Ford", "Explorer", 1989, "Blue");
            string strmyThirdCarProperties = string.Format("myCar properties: {0} {1} {2} {3}", myThirdCar.Make, myThirdCar.Model, myThirdCar.Year, myThirdCar.Color);
            CreateTestOutput(strmyThirdCarProperties);

            // static methods in classes
            /* call static method in Car class (static methods in classes do not require us to instantiate  or create a new class object
            - we can simply call them - no need for a new instance of the Car class */
            Car.MyMethod();

            // close references to the objects
            myOtherCar = null;
            myCar = null;
        }

        private static void CreateTestOutput(string strOutPut)
        {
            // write to the debug output window (seen after code is done running)
            // using Debug class requires a Using statment for using System.Diagnostics
            Debug.WriteLine("");
            Debug.WriteLine("------------");
            Debug.WriteLine("DEBUG OUTPUT FOR TESTING PURPOSES...");
            Debug.WriteLine(strOutPut);
            Debug.WriteLine("------------");
            Debug.WriteLine("");

            // write to the console window
            Console.WriteLine("");
            Console.WriteLine(strOutPut);
            Console.WriteLine("");
            Console.WriteLine("Check output window in IDE for more output.");
            Console.WriteLine("Press any key to return...");
            Console.ReadKey();
        }
    }

    class Car
    {
        /* class object properties:
        you can use intellisense to create new properties through the use of "prop <tab> <tab>" to create a new property skeletone that looks like this 
        public int MyProperty { get; set; } - a nice start for creating new class properties */

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

         // some more properties
        public decimal OriginalPrice { get; set; } // additional property added for this exmaple
        public int MyProperty { get; set; }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Constructors - allows the assignment of values during the instantiation of a new class object
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        // constructor method of the car class = defined within the Class, this assigns or gets a default value for a property of the class object (in this case assigns a value for "Make" property
        // basic constructor method of the Car class:
        public Car()
        {
            // you could load this from a configuration file or database but we will hard code the value
            // inherent value of the Car class can be established as follows so that whenever a new instance of this class is instantiated, 
            // it already has the property value of .Make set to "Nissan"
            this.Make = "Ford"; // the This keyword is OPTIONAL and simply to refers to the origin of the instance of this object we are doing stuff to right now
            Make = "Nissan"; // Also works the same way...
        }
        
        // overloaded constructor method of the Car class:
        public Car(string strMake, string strModel, int intYear, string strColor)
        {
            Make = strMake;
            Model = strModel;
            Year = intYear;
            Color = strColor;
        }

        // very simple class method - returns a value or reference when called fomr another place in code
        private static double DetermineMarketValueRef(Car _car)
        {
            // hard-code value of carValue
            double carValue = 100.00;
            return carValue;
        }

        // another class method - returns a value or reference when called fomr another place in code
        // takes no passed variable or object
        public double DetermineMarketValue()
        {
            // hard-code value of carValue
            double carValue = 0.00;

            if (this.Year > 1990) // the "this" keyword allows you access all of the private and public members of a class
                carValue = 10000.00;
            else
                carValue = 2000.00;
            return carValue;
        
        /*
        classes have:
        instance members (those created when a new instance of the class object is created
        static member - those provided by static methods in the class - like utilities or tools...
        Below is an example of a static member of a class
        */
        }
        public static void MyMethod()
        {
            Console.WriteLine("Called the static MyMethod");
            Console.ReadLine();
        }

    }

}
