using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // create an instance of the MathOperations class
            MathOperations mathOps = new MathOperations();

            //Ask the user for a number
            Console.WriteLine("Enter a whole number: ");

            //Read user input from the console
            string userInput = Console.ReadLine();

            //Convert input (string)into an integer
            int userNumber = Convert.ToInt32(userInput);

            //Call AddTen method asd store returned value
            int result1 = mathOps.AddTen(userNumber);
            Console.WriteLine("After adding 10: " + result1);

            //Call MultiplyByFive method and store returned value
            int result2 = mathOps.MultiplyByFive(userNumber);
            Console.WriteLine("After multiplying by 5: " + result2);

            //Call SquareNumber method and store returned value
            int result3 = mathOps.SquareNumber(userNumber);
            Console.WriteLine("After squaring the number: " + result3);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid whole number.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("The number entered is too large or too small.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }

        //Pause so user can read the results
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }

    // This class contains three methods that each take an integer
    // and return an integer after performing a math operation.
    public class MathOperations
    {
        // This method adds 10 to the input value.
        public int AddTen(int number)
        {
            return number + 10; // Add 10 and return result
        }

        // This method multiplies the input value by 5.
        public int MultiplyByFive(int number)
        {
            return number * 5; // Multiply by 5 and return result
        }

        // This method squares the input value (number × number).
        public int SquareNumber(int number)
        {
            return number * number; // Square the number and return result
        }
    }
}
