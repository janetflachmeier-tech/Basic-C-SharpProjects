using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanComparisonAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This is a do while loop
            int count = 0;

            do
            {
                Console.WriteLine("Inside the loop");
                count++; //add 1 to count each time
            } while (count < 5); //loop will run while count is less than 5

            // This is while loop
            int number = 0; 
            while (number < 3) // loop will run while number is less than 3
            {
                Console.WriteLine("Counting numbers");
                number++; //add 1 to number each time
            }
            Console.ReadLine();
        }
    }
}
