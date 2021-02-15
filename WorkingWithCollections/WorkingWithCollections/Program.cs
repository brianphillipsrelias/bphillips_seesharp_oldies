using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithCollections
// Collections are a type of array in C#
/*
   There are many types of Collections in C# - each one manages, creates, uses a different data type like lists and dictionaries
   The .Net framwework uses both Arrays and Collections throughout is default code libraries andf classes...

*/
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate class objects and their values
            Car car1 = new Car();
            car1.Make = "Oldsmobile";
            car1.Model = "Cutlass Supreme";
            car1.VIN = "A1";

            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Model = "Prism";
            car1.VIN = "B2";

            Book b1 = new Book();
            b1.Author = "Robert Tabor";
            b1.Title = "Microsoft .NET XML Web Services";
            b1.ISBN = "0-000-00000-0";

            ////////////////////////////////////////////////////////////////////////////////////////////
            // OLDER STYLE COLLECTION CALLED ARRAYLIST
            ////////////////////////////////////////////////////////////////////////////////////////////

            //ArrayLists are dynamically sized (no need to pre-size them)
            //they also support cool features like sorting and real-time manipulation

            /*
            - this code below will fail because the 3rd item added (book) is not of type Car and cannot be converted to Car
            - a type cast exception will happen
            - C# has since fixed this b y adding new style Collections
            - C$ still allows the coder to include such out of bounds object types to be included in older Collections for backward-compatibility reasons
            */
            /*
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(b1); //adding a book object to a Collection
            foreach (Car car in myArrayList)
            {
                Console.WriteLine(car.Make);
                Console.ReadLine();
            }
            */
            ////////////////////////////////////////////////////////////////////////////////////////////
            // NEWER STYLE COLLECTIONS CALLED GENERICS OR GENERIC COLLECTIONS
            // There are many kinds; but examples include List, Dictionary, and 
            ////////////////////////////////////////////////////////////////////////////////////////////

            // List generic Collection type
            // List <T>
            List<Car> myCarList = new List<Car>();
            myCarList.Add(car1);
            myCarList.Add(car2);
            int iCounter = 0;
            foreach (Car car in myCarList)
	        {
                iCounter = iCounter + 1;
                Console.WriteLine("Car #" + iCounter);
                Console.WriteLine(car.Make);
                Console.WriteLine(car.Model);
                Console.WriteLine("");
                Console.ReadLine();

	        }
            // Dictionary generic Collection type
            // Dictionary<TKey, TValue>
            Dictionary<string, Car> myCarDictionary = new Dictionary<string, Car>();
            myCarDictionary.Add(car1.VIN, car1);
            myCarDictionary.Add(car2.VIN, car2);
            Console.WriteLine(myCarDictionary["B2"].Make);
            Console.ReadLine();


            ////////////////////////////////////////////////////////////////////////////////////////////
            // initializing Collections with values
            ////////////////////////////////////////////////////////////////////////////////////////////

            // for arrays, example of initializing an array with values (very basic line from standard array training) - an array of strings:
            string[] names = { "Bob", "Steve", "Brian", "Chuck" };

            // you can do the same thing with objects where you provide the value at the point of instantiation
            // this is a called an object initializer:
            Car oCar1 = new Car() { Make = "BMW", Model = "750Li", VIN = "C3" };
            Car oCar2 = new Car() { Make = "Toyota", Model = "4Runner", VIN = "C4" };
            Car oCar3 = new Car() { Make = "Meercedes-Benz", Model = "GLK350", VIN = "C5" };

            // Collection Initializer
            // create, initialize, and populate the items in an array all in one line of code...
            List<Car> myInitializedCarList = new List<Car>()
            {
                new Car {Make="Oldsmobile", Model="Cutlas Supreme", VIN="E5"},
                new Car {Make="Nissan", Model="Altima", VIN="F6"}
            };
            Console.WriteLine(myInitializedCarList);
            Console.ReadLine();
        }
    }
    class Car //sinmple class
    {
        public string VIN { get; set; }
        public string Make {get; set;}
        public string Model {get; set;}

    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

    }
}
