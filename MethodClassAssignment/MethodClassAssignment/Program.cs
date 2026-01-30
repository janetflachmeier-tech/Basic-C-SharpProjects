using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the method by passing in two numbers directly
            mathOps.PerformOperation(10, 5);

            // Call the method again, this time specifying the parameters by name
            mathOps.PerformOperation(num1: 20, num2: 8);

            // Keep the console window open
            Console.ReadLine();
        }
    }

    // Create a class called MathOperations
    internal class MathOperations
    {
        // Create a void method that takes two integer parameters
        public void PerformOperation(int num1, int num2)
        {
            // Perform a math operation on the first integer (multiply by 2)
            int result = num1 * 2;

            // Display the result of the math operation
            Console.WriteLine("The first number multiplied by 2 is: " + result);

            // Display the second integer to the screen
            Console.WriteLine("The second number is: " + num2);

            // Add a blank line for better readability
            Console.WriteLine();
        }
    }
}
