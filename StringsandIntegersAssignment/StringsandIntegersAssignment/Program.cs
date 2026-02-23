using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsandIntegersAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of integers
            List<int> numbers = new List<int>() { 20, 40, 60, 80, 100 };

            //Display the of numbers to the user
            Console.WriteLine("List of numbers:" + string.Join(", ", numbers));

            // Ask the user to enter a number to search for
            Console.WriteLine("Enter a number to divide each number in the list by:");

            // Wrap the following code in a try/catch block to handle catch any errors
            try
            {
                //Read the user's input from the console
                string userInput = Console.ReadLine();

                // Convert the user's input to an integer
                int divisor = Convert.ToInt32(userInput);

                //Loop through each number in the list and divide it by the user's input
                foreach (int number in numbers)
                {
                    //Divide the number by the user's input and display the result
                    int quotient = number / divisor;
                    int remainder = number % divisor;
                    Console.WriteLine($"{number} divided by {divisor} is {quotient} with remainder {remainder}");
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Please enter a non-zero divisor.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input format. Please enter a valid whole number.");
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a whole number.");
            }
            finally
            {
                //Inform the user that the program has ended
                Console.WriteLine("The program has ended. Press any key to exit.");
                Console.ReadLine();
            }
        }
    }
}
