using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Display welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt user for package weight
            Console.WriteLine("Please enter the package weight:");
            // Convert input to decimal for calculations
            decimal weight = Convert.ToDecimal(Console.ReadLine());

            // Check if weight exceeds 50
            if (weight > 50)
            {
                // Display error message and exit program
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // Ends the program
            }

            // Prompt user for package width
            Console.WriteLine("Please enter the package width:");
            decimal width = Convert.ToDecimal(Console.ReadLine());

            // Prompt user for package height
            Console.WriteLine("Please enter the package height:");
            decimal height = Convert.ToDecimal(Console.ReadLine());

            // Prompt user for package length
            Console.WriteLine("Please enter the package length:");
            decimal length = Convert.ToDecimal(Console.ReadLine());

            // Check if total dimensions exceed 50
            if ((width + height + length) > 50)
            {
                // Display error message and exit program
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // Ends the program
            }

            // Calculate shipping quote:
            // Multiply dimensions together, then multiply by weight, then divide by 100
            decimal quote = (width * height * length) * weight / 100;

            // Display the quote formatted as currency
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("F2"));
            Console.WriteLine("Thank you!");
        }
    }
}
