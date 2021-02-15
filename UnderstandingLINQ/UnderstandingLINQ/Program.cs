using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingLINQ
{ 
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    // LINQ: Language-Integrated Query framework
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    class Program
    {
        static void Main(string[] args)
        {
            // 

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // List (collection) we will create and use for code samples below
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Here we create & fill a collection of Car class objects with values (collection initialized class)
            // This is filled with data (Car class values) that we can search and sort on...

            List<Car> myCars = new List<Car>()
            {
                new Car() { VIN="A1", Make = "BMW", Model= "550i", StickerPrice=55000, Year=2009},
                new Car() { VIN="B2", Make="Toyota", Model="4Runner", StickerPrice=35000, Year=2011},
                new Car() { VIN="C3", Make="BMW", Model = "745li", StickerPrice=75000, Year=2008},
                new Car() { VIN="D4", Make="Ford", Model="Escape", StickerPrice=25000, Year=2007},
                new Car() { VIN="E5", Make="BMW", Model="55i", StickerPrice=57000, Year=2010}
            };

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // 2 ways to form query syntax for LINQ: 1) Query 2) Method
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // (1) LINQ QUERY
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /*
            - LINQ QUERY sample code to find all of the BMWs in the collection we have made:
            - bmws variable below is a subset collection variable (var) created and filled by methods inside of System/Linq classes we can use to do queries
            - the var keyword in C# has a special meaning - it means that we are going to let the compiler figure out the appropriate data type for this collection...
            */

            // find all of the BMW cars in the collection and then load them into a subset collection called bmws
            /*
            var bmws = from qCar in myCars
                       where qCar.Make == "BMW"
                       select qCar;
            */

            // 3 ways to write this out:
            // 1 - write directly to console window while walkng through quesry results
            /*
            foreach (var qCar in bmws)
            {
                Console.WriteLine("{0} {1} {2} {3}", qCar.Year, qCar.Make, qCar.Model, qCar.VIN);
            }
            */
            // 2 - use string after walking through query results
            /*
            foreach (var qCar in bmws)
            {
                string strBMWSpecs = string.Format("{0} {1} {2} {3}", qCar.Year, qCar.Make, qCar.Model, qCar.VIN);
                Console.WriteLine;
            }
            */
            // 3 -  use method, passing query results
            /*
            CreateTestOutputForList(bmws);
            */

            // ANOTHER SAMPLE OF LINQ QUERY - add another criteria to query - also find BMWs where the year is for 2009:
            /*
            var bmws = from qCar in myCars
                       where qCar.Make == "BMW"
                       && qCar.Year == 2009
                       select qCar;
            foreach (var qCar in bmws)
            {
                Console.WriteLine("{0} {1} {2} {3}", qCar.Year, qCar.Make, qCar.Model, qCar.VIN);
            }
            Console.ReadLine();
            */

            // ANOTHER SAMPLE OF LINQ QUERY - order the elements of a collection
            /*
            var orderedCars = from qCar in myCars
                              orderby qCar.Year descending
                              select qCar;
            
            foreach (var qCar in orderedCars)
            {
                Console.WriteLine("{0} {1} {2} {3}", qCar.Year, qCar.Make, qCar.Model, qCar.VIN);
            }
            Console.ReadLine();
            */

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // (2) LINQ METHOD
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /*
            - (2)LINQ METHOD (uses <collection>.Where method) sample code to find all of the BMWs in the collection we have made:
            - bmws is a subset collection variable (again using the var keyword) that is created and filled by methods inside of System/Linq classes we can use to do queries
            - the below method is called a Lambda expression in math (a mini-method for code) - where p is an arbitrary value/variable that represents the collection you created above in the code - can be anything...
            - basically this code below says, use the var to create a query where in myCars collection the collection item (p) is equal to or greater than
            */

            // basic samples of LINQ method syntax
            // var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2010);
            // var bmws = myCars.Where(x => x.Make == "BMW"); // x works as well as a variable that represents the collection of cars in myCars

            // another version using yet another variable fr the collection (myCars) that also only returns BMWs where the Year = 2010:
            // var bmws = myCars.Where(ThismyCarsItem => ThismyCarsItem.Make == "BMW" && ThismyCarsItem.Year == 2010);

            // CREATE OUTPUT for bmws collection samples
            /*
            foreach (var qCar in bmws)
            {
                Console.WriteLine("{0} {1} {2} {3}", qCar.Year, qCar.Make, qCar.Model, qCar.VIN);
            }
            Console.ReadLine();
            */

            // order the elements of a collection
            // order the list of the cars by Year via LINQ METHOD syntax
            // var orderedCars = myCars.OrderByDescending(x => x.Year);

            // CREATE OUTPUT for orderedCars collection sample
            /*
            foreach (var qCar in orderedCars)
            {
                Console.WriteLine("{0} {1} {2} {3}", qCar.Year, qCar.Make, qCar.Model, qCar.VIN);
            }
            Console.ReadLine();
            */

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // More LINQ Method samples
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // find the first item in the collection where the Make is BMW
            /*
            var firstBMW = myCars.First(x => x.Make == "BMW"); //returns single car
            string strFirstBMWSpecs = string.Format("{0} {1} {2} {3}", firstBMW.Year, firstBMW.Make, firstBMW.Model, firstBMW.VIN);
            string strOutputFirstBMW = "First car in collection: " + strFirstBMWSpecs;
            CreateTestOutput(strOutputFirstBMW);
            */

            //  return the first BMW in the list but in descending order
            /*
            var firstBMWDescending = myCars.OrderByDescending(x => x.Year).First(x => x.Make == "BMW"); // notice the use of .First to scrape out the first BMW from the query
            string strFirstBMWSpecsDescending = string.Format("{0} {1} {2} {3}", firstBMWDescending.Year, firstBMWDescending.Make, firstBMWDescending.Model, firstBMWDescending.VIN);
            string strOutputFirstBMWDescending = "First car in collection in descending order: " + strFirstBMWSpecsDescending;
            CreateTestOutput(strOutputFirstBMWDescending);
            */

            // query to check on all itmes in List
            /*
            // Console.WriteLine(myCars.TrueForAll(x => x.Year > 2012)); // returns false
            Console.WriteLine(myCars.TrueForAll(x => x.Year > 2005)); // returns true
            Console.ReadLine();
            */

            // use ForEach to query directly
            // myCars.ForEach(itemCar => Console.WriteLine("VIN:{0} Sticker:{1:C} {2} {3} ", itemCar.VIN, itemCar.StickerPrice, itemCar.Make, itemCar.Model)); Console.ReadLine();

            // directly alter value (change sticker price for each)
            // myCars.ForEach(p => p.StickerPrice -= 3000);
            // myCars.ForEach(itemCar => Console.WriteLine("VIN:{0} Sticker:{1:C} {2} {3} ", itemCar.VIN, itemCar.StickerPrice, itemCar.Make, itemCar.Model)); Console.ReadLine();

            // check if one thing is true (is there car in the List where the Model == 745li
            // Console.WriteLine(myCars.Exists(itemCar => itemCar.Model == "745li")); Console.ReadLine();

            // write out a total of values (in this case the total value of all of the cars via combined sticker price
            // Console.WriteLine(myCars.Sum(listitemCar => listitemCar.StickerPrice)); Console.ReadLine();

            // now format it nicely :-)
            // Console.WriteLine(string.Format("{0:C}", (myCars.Sum(cars => cars.StickerPrice)))); Console.ReadLine();

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //   Using GetType method to understand what may be behind the Var in terms of data types in the case of these complex LINQ queries etc   //
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //
            // for simple List:
            // Console.WriteLine(myCars.GetType()); Console.ReadLine(); // returns "System.Collections.Generic.List"
            //
            // for ordered list query:
            // var orderedCars = myCars.OrderByDescending(x => x.Year);
            // Console.WriteLine(orderedCars.GetType()); Console.ReadLine(); // returns "System.Linq.OrderedEnumerable - ordered query sublist"
            //
            // for simple where statement:
            // var bmws = myCars.Where(foo => foo.Make == "BMW" && foo.Year == 2010);
            // Console.WriteLine(bmws.GetType()); Console.ReadLine(); // returns "System.Linq.Enumerable+WhereListIterator`1[UnderstandingLINQ.Car]"
            //
            // One more cool one regarding var data types: Projection
            // Projection in C# allows the code to project values into a new data type anonymously (of unknown name etc) - this allows us to define types at runtime and just use what we need. 
            // The sample here ultimatley exists in this lesson not to teach projection, but to further show how complex the data types created and maintainedf by the "var" construct are
            // the sample is uing the LINQ query syntax to project values from the initial query into a var structure called newCars
            // var newCars = from qCar in myCars where qCar.Make == "BMW" && qCar.Year == 2009 select new { qCar.Make, qCar.Model }; 
            // Console.WriteLine(newCars.GetType()); Console.ReadLine(); // returns "System.Linq.Enumerable+WhereSelectListIterator`2[UnderstandingLINQ.Car,<>f__AnonymousType0`2[System.String,System.String]]"
            //
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //   What these samples show is that the var keyword/variable/object simplifies and great number of possibly complex query and List data types.   //
            //   They are hidden from most of us since it is not vital to basic coding that we understand all of these in detail...                           //
            //   There is obviously A LOT going on under the hood wen using LINQ...
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        }

        public static void CreateTestOutputForList(IEnumerable<Car> testoutputCarList)
        {
            // write to the debug output window (seen after code is done running)
            // using Debug class requires a Using statment for using System.Diagnostics
            Debug.WriteLine("");
            Debug.WriteLine("------------");
            Debug.WriteLine("DEBUG OUTPUT FOR TESTING PURPOSES TYPICALLY");
            Debug.WriteLine("");
            Debug.WriteLine("------------");
            Debug.WriteLine("");
            // write to the console window
            Console.WriteLine("");
            Console.WriteLine();
            foreach (var qCar in testoutputCarList)
            {
                // Console.WriteLine("{0} {1} {2} {3}", qCar.Year, qCar.Make, qCar.Model, qCar.VIN);
                string strBMWSpecs = string.Format("{0} {1} {2} {3}", qCar.Year, qCar.Make, qCar.Model, qCar.VIN);
                Console.WriteLine(strBMWSpecs);
            }
            Console.WriteLine("Check output window in IDE for more output...");
            Console.WriteLine("");
            Console.WriteLine("Press any key to return...");
            Console.ReadKey();
        }

        public static void CreateTestOutput(string strTestOutput)
        {
            // write to the debug output window (seen after code is done running)
            // using Debug class requires a Using statment for using System.Diagnostics
            Debug.WriteLine("");
            Debug.WriteLine("------------");
            Debug.WriteLine("DEBUG OUTPUT FOR TESTING PURPOSES TYPICALLY");
            Debug.WriteLine("");
            Debug.WriteLine("------------");
            Debug.WriteLine("");
            // write to the console window
            Console.WriteLine("");
            Console.WriteLine(strTestOutput);
            Console.WriteLine("");
            Console.WriteLine("Check output window in IDE for more output...");
            Console.WriteLine("");
            Console.WriteLine("Press any key to return...");
            Console.ReadKey();
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
    }
}

