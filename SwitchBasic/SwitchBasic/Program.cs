using System;
using System.Diagnostics;
public enum Color {Red, Green, Blue};

namespace SwitchBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            // basic example of the switch statement
            // The switch statement is often used as an alternative to an if-else construct if a single expression is tested against three or more conditions.
            // For example, the following switch statement determines whether a variable of type Color has one of three values: 

            Color c = (Color) (new Random()).Next(0, 3);
            switch (c)
            {
                case Color.Red:
                    Console.WriteLine("The color is red");
                break;
                case Color.Green:
                    Console.WriteLine("The color is green");
                break;
                case Color.Blue:
                    Console.WriteLine("The color is blue");   
                break;
                default:
                    Console.WriteLine("The color is unknown.");
                break;

            }
            Console.WriteLine("Press any key to end...");
            Console.ReadKey();
        }
    }
}
