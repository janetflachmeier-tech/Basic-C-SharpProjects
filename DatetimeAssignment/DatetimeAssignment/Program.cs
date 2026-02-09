using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DatetimeAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Print the current date and time to the console
            // DateTime.Now gets the current date and time from the system clock
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine("Current Date and Time: " + currentDateTime);
            
            // Ask the user to enter a number representing hours
            Console.WriteLine("\nPlease enter a number of hours:");
            
            // Read the user's input as a string from the console
            string userInput = Console.ReadLine();
            
            // Convert the string input to an integer
            // This represents the number of hours to add to the current time
            int hoursToAdd = Convert.ToInt32(userInput);
            
            // Calculate the future date and time by adding the specified hours
            // AddHours() method adds the specified number of hours to the current DateTime
            DateTime futureDateTime = currentDateTime.AddHours(hoursToAdd);
            
            // Display the calculated future date and time to the console
            Console.WriteLine("\nIn " + hoursToAdd + " hour(s), it will be: " + futureDateTime);
            
            // Create a log file to store the results
            // Define the file path for the log file in the current directory
            string logFilePath = "datetime_log.txt";
            
            // Create the content to write to the file
            string logContent = "Current Date and Time: " + currentDateTime + "\n" +
                               "Hours Added: " + hoursToAdd + "\n" +
                               "Future Date and Time: " + futureDateTime + "\n" +
                               "-----------------------------------\n";
            
            // Append the content to the log file (creates the file if it doesn't exist)
            File.AppendAllText(logFilePath, logContent);
            
            // Notify the user that the results have been saved
            Console.WriteLine("\nResults have been saved to " + logFilePath);
            
            // Keep the console window open until the user presses a key
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
