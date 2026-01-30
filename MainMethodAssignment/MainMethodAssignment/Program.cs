using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    // Class that contains overloaded methods for mathematical operations
    internal class MathOperations
    {
        // First Method that takes an integer, multiplies it by 5, and returns the result as an integer
        public int PerformOperation(int number)
        {
            // Multiply the input integer by 5
            int result = number * 5;
            // Return the calculated result
            return result;
        }

        // Second Method that takes a decimal, divides it by 2, and returns the result as an integer
        public int PerformOperation(decimal number)
        {
            // Divide the input decimal by 2
            decimal calculation = number / 2;
            // Convert the decimal result to an integer (truncates decimal places)
            int result = (int)calculation;
            // Return the calculated result
            return result;
        }

        // Method that takes a string, converts it to an integer, adds 10, and returns the result as an integer
        public int PerformOperation(string number)
        {
            // Convert the string to an integer using int.Parse
            int convertedNumber = Convert.ToInt32(number);
            // Add 10 to the converted integer
            int result = convertedNumber + 10;
            // Return the calculated result
            return result;
        }
    }

    class Program
    {
        static void Main()
        {
            // Instantiate the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the first method with an integer parameter
            int intResult = mathOps.PerformOperation(20);
            // Display the result to the console
            Console.WriteLine("Integer operation result: " + intResult);

            // Call the second method with a decimal parameter
            int decimalResult = mathOps.PerformOperation(25.5m);
            // Display the result to the console
            Console.WriteLine("Decimal operation result: " + decimalResult);

            // Call the third method with a string parameter
            int stringResult = mathOps.PerformOperation("15");
            // Display the result to the console
            Console.WriteLine("String operation result: " + stringResult);

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}

