using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment
{
    // Define an enum to represent the days of the week
    public enum DaysOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Wrap the parsing logic in a try/catch block to handle invalid input
            try
            {
                // Prompt the user to enter the current day of the week
                Console.WriteLine("Please enter the current day of the week:");

                // Read the user's input from the console
                string userInput = Console.ReadLine();

                // Parse the string input to the DaysOfWeek enum type
                // Enum.Parse converts a string to its corresponding enum value
                // The second parameter (true) makes the parsing case-insensitive
                DaysOfWeek currentDay = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), userInput, true);

                // Display the parsed enum value to the user
                Console.WriteLine("You entered: " + currentDay);
            }
            // Catch any exceptions that occur during parsing (e.g., invalid day name)
            catch (ArgumentException)
            {
                // Print error message if the user enters an invalid day of the week
                Console.WriteLine("Please enter an actual day of the week.");
            }

            // Keep the console window open until the user presses a key
            Console.ReadLine();
        }
    }
}
