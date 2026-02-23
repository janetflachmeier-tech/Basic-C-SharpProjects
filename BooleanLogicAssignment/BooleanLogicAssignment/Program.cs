using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // Ask the applicant for their age
        Console.WriteLine("What is your age?");
        // Convert input to integer for comparison
        int age = Convert.ToInt32(Console.ReadLine());

        // Ask if the applicant has ever had a DUI
        Console.WriteLine("Have you ever had a DUI? (true/false)");
        // Convert input to boolean (true or false)
        bool hasDUI = Convert.ToBoolean(Console.ReadLine());

        // Ask how many speeding tickets the applicant has
        Console.WriteLine("How many speeding tickets do you have?");
        // Convert input to integer for comparison
        int speedingTickets = Convert.ToInt32(Console.ReadLine());

        // Apply qualification rules:
        // 1. Age must be greater than 15
        // 2. Applicant must NOT have a DUI
        // 3. Applicant must have 3 or fewer speeding tickets
        bool isQualified = (age > 15) && (hasDUI == false) && (speedingTickets <= 3);

        // Print the result of the qualification check
        Console.WriteLine("Qualified?");
        Console.WriteLine(isQualified);
    }
}
