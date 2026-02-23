using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Wrap the entire program in a try-catch block to handle any unexpected errors
            try
            {
                // Instantiate the MathOperations class
                MathOperations mathOps = new MathOperations();

                // Declare a variable to store the first number
                int firstNumber;

                // Use a try-catch block to handle invalid input for the first number
                try
                {
                    // Prompt the user to enter the first number
                    Console.WriteLine("Please enter the first number:");
                    // Read the first number input and convert it to an integer
                    firstNumber = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    // Handle the case where the user enters non-numeric input
                    Console.WriteLine("Error: Invalid input. Please enter a valid integer.");
                    Console.WriteLine("\nPress any key to exit...");
                    Console.ReadKey();
                    return; // Exit the program
                }
                catch (OverflowException)
                {
                    // Handle the case where the number is too large or too small for an integer
                    Console.WriteLine("Error: Number is too large or too small. Please enter a valid integer.");
                    Console.WriteLine("\nPress any key to exit...");
                    Console.ReadKey();
                    return; // Exit the program
                }

                // Prompt the user to enter the second number (optional)
                Console.WriteLine("Please enter the second number (or press Enter to skip):");
                // Read the second number input as a string
                string secondInput = Console.ReadLine();

                // Declare a variable to store the result
                int result;

                // Check if the user entered a value for the second number
                if (string.IsNullOrWhiteSpace(secondInput))
                {
                    // If no second number was entered, call the method with only the first number
                    result = mathOps.MultiplyNumbers(firstNumber);
                    Console.WriteLine("You entered only one number.");
                }
                else
                {
                    // Use a try-catch block to handle invalid input for the second number
                    try
                    {
                        // If a second number was entered, convert it to an integer
                        int secondNumber = Convert.ToInt32(secondInput);
                        // Call the method with both numbers
                        result = mathOps.MultiplyNumbers(firstNumber, secondNumber);
                        Console.WriteLine("You entered two numbers.");
                    }
                    catch (FormatException)
                    {
                        // Handle the case where the user enters non-numeric input for the second number
                        Console.WriteLine("Error: Invalid input for second number. Please enter a valid integer.");
                        Console.WriteLine("\nPress any key to exit...");
                        Console.ReadKey();
                        return; // Exit the program
                    }
                    catch (OverflowException)
                    {
                        // Handle the case where the second number is too large or too small
                        Console.WriteLine("Error: Second number is too large or too small.");
                        Console.WriteLine("\nPress any key to exit...");
                        Console.ReadKey();
                        return; // Exit the program
                    }
                }

                // Display the result of the math operation
                Console.WriteLine("Result: " + result);
            }
            catch (Exception ex)
            {
                // Catch any other unexpected exceptions
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
            finally
            {
                // The finally block always executes, ensuring the console stays open
                // Keep the console window open until the user presses a key
                Console.WriteLine("\nPress any key to exit...");
                Console.ReadKey();
            }
        }
    }

    // Create a class to perform math operations
    class MathOperations
    {
        // Method that takes two integer parameters, with the second parameter being optional (default value is 10)
        // The method multiplies the first number by the second number
        public int MultiplyNumbers(int num1, int num2 = 10)
        {
            // Perform multiplication operation
            int result = num1 * num2;
            // Return the result
            return result;
        }
    }
}
