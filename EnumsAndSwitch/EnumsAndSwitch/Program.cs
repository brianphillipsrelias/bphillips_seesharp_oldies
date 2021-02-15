using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace EnumsAndSwitch
{
    class Program
    {
        static void Main(string[] args)
        {

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Switches - conditional operator used for many potential cases at once - used to control code flow based on - 
            // multiple decisions (like a huge if/then/else). 
            //
            // Enum (an enumeration) data type structure that limits and constrains all values specific to our - 
            // given system or class module, program, etc...
            // It gives a textual equivalent to a numerical value - rem oving any ambiguity in the system
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Create a list called lstTodos that we will use for evaluation and reported - we create the List and also apply values like .Status when doing this
            List<Todo> lstTodos = new List<Todo>()
            {
                new Todo { Description = "Task 1", EstimatedHours = 6, Status = Status.Completed },
                new Todo { Description = "Task 2", EstimatedHours = 2, Status = Status.InProgress },
                new Todo { Description = "Task 3", EstimatedHours = 8, Status = Status.OnHold },
                new Todo { Description = "Task 4", EstimatedHours = 12, Status = Status.Deleted },
                new Todo { Description = "Task 5", EstimatedHours = 6, Status = Status.InProgress },
                new Todo { Description = "Task 6", EstimatedHours = 2, Status = Status.NotStarted },
                new Todo { Description = "Task 7", EstimatedHours = 14, Status = Status.NotStarted },
                new Todo { Description = "Task 8", EstimatedHours = 8, Status = Status.Completed },
                new Todo { Description = "Task 9", EstimatedHours = 8, Status = Status.InProgress },
                new Todo { Description = "Task 10", EstimatedHours = 8, Status = Status.Completed },
                new Todo { Description = "Task 11", EstimatedHours = 4, Status = Status.NotStarted },
                new Todo { Description = "Task 12", EstimatedHours = 10, Status = Status.Completed },
                new Todo { Description = "Task 13", EstimatedHours = 12, Status = Status.Deleted },
                new Todo { Description = "Task 14", EstimatedHours = 6, Status = Status.Completed }
            };

            // call method to print out information about the listTodo list items -  in this case use enaums, foreach, and a switch statement
            // to apply conditional logic to different items in the lstTodos list
            PrintAssessment(lstTodos); 
        }
        private static void PrintAssessment(List<Todo> todos)
        // using switch statement below
        
        {
            CreateTestOutput("task list status output follows: ");

            foreach (var todo in todos)
            {
                /*
                When using switch, the following 2 cool actions are available:
                1 - when typing switch then tab, tab - you get a nice switch statement all formatted. Like with foreach etc... // default: is the default case for all switch statements
                
                switch (switch_on)
                {
                    default: 
                }
                
                2 - when in newly created switch statement structure, enter the variable we are switching on in parens (like todo.Status below) then press enter, enter and 
                Visual Studio will fire out all of the possible switch statement cases based on the possible enums for the todo.Status enum:
                
                switch (todo.Status<hit enter, enter here>)
                {
                    case Status.NotStarted:
                        break;
                    case Status.InProgress:
                        break;
                    case Status.OnHold:
                        break;
                    case Status.Completed:
                        break;
                    case Status.Deleted:
                        break;
                    default:
                        break;
                }   
                */

                switch (todo.Status)
                {
                    case Status.NotStarted:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case Status.InProgress:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case Status.OnHold:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;
                    case Status.Completed:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case Status.Deleted:
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        break;
                    default:
                        break;
                }

                // write out the item itself
                Console.WriteLine(todo.Description);
                Debug.WriteLine(todo.Description);

            }

            FinishTestOutput("end of task status list...");
        }
        public static void CreateTestOutput(string strTestOutput)
        {
            // write to the debug output window (seen after code is done running)
            // using Debug class requires a Using statment for using System.Diagnostics
            Debug.WriteLine("");
            Debug.WriteLine("---------------------------------");
            Debug.WriteLine("DEBUG OUTPUT FOR TESTING PURPOSES:");
            Debug.WriteLine("---------------------------------");
            Debug.WriteLine(strTestOutput);
            
            // write to the console window
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("CONSOLE OUTPUT FOR TESTING PURPOSES:");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(strTestOutput);
            Console.WriteLine(""); 

        }

        public static void FinishTestOutput(string strFinishTestOutput)
        {
            // write to the debug output window (seen after code is done running)
            // using Debug class requires a Using statment for using System.Diagnostics
            Debug.WriteLine("");
            Debug.WriteLine("---------------------------------");
            Debug.WriteLine("END OF DEBUG OUTPUT...");
            Debug.WriteLine("---------------------------------");
            Debug.WriteLine("");
            // write to the console window
            Console.WriteLine("");
            Console.WriteLine(strFinishTestOutput);
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("END OF CONSOLE TEST OUTPUT...");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Check Output window in IDE for additonal debug output...");
            Console.WriteLine("");
            Console.WriteLine("Press any key to return...");
            Console.WriteLine("");
            Console.ReadKey();

        }
    }

    class Todo
    {
        public string Description { get; set; }
        public int EstimatedHours { get; set; }
        public Status Status { get; set; }
    }

    // this enum statement below creates 5 possible states of a Todo class item's Status property - these can be literally anything,
    // but they are defined for the context of the Class for easier reading, understanding, etc
    enum Status
    {
        NotStarted,
        InProgress,
        OnHold,
        Completed,
        Deleted
    }

}

