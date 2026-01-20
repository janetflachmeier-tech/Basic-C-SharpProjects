using System;


namespace ConsoleAppAssignement
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Multiply input by 50
            Console.WriteLine("Enter a number to multiply by 50:");
            double input1 = Convert.ToDouble(Console.ReadLine()); 
            double result1 = input1 * 50;
            Console.WriteLine("Result after multiplying by 50: " + result1);

            //2. Add 25 to input
            Console.WriteLine("Enter a number to add 25:");
            double input2 = Convert.ToDouble(Console.ReadLine());
            double result2 = input2 + 25;
            Console.WriteLine("Result after adding 25: " + result2);

            //3. Divide input by 12.5
            Console.WriteLine("Enter a number to divide by 12.5:");
            double input3 = Convert.ToDouble(Console.ReadLine());
            double result3 = input3 / 12.5;
            Console.WriteLine("Result after dividing by 12.5: " + result3);

            //4. Check if input is greater than 50
            Console.WriteLine("Enter a number to check if it's greater than 50:");
            double input4 = Convert.ToDouble(Console.ReadLine());
            bool isGreaterThan50 = input4 > 50;
            Console.WriteLine("Is the number greater than 50? " + isGreaterThan50);

            //5. Divide input by 7 and get the remainder
            Console.WriteLine("Enter a number to divide by 7 and get the remainder:");
            int input5 = Convert.ToInt32(Console.ReadLine());

            int remainder = input5 % 7;
            Console.WriteLine("Remainder after dividing by 7: " + remainder);

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();



        }
    }
}
