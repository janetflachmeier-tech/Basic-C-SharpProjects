using System;

namespace MathandComparisonOperatorsAssignment
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("What is your hourly rate?");
            string hourlyRate1 = Console.ReadLine();
            Console.WriteLine("How many hours do you work per week?");
            string hoursPerWeek1 = Console.ReadLine();

            Console.WriteLine("Person 2");
            Console.WriteLine("What is your hourly rate?");
            string hourlyRate2 = Console.ReadLine();
            Console.WriteLine("How many hours do you work per week?");
            string hoursPerWeek2 = Console.ReadLine();

            int annualSalary1 = Convert.ToInt32(hourlyRate1) * Convert.ToInt32(hoursPerWeek1) * 52;
            int annualSalary2 = Convert.ToInt32(hourlyRate2) * Convert.ToInt32(hoursPerWeek2) * 52;
            Console.WriteLine("Annual salary of Person 1: " + annualSalary1);
            Console.WriteLine("Annual salary of Person 2: " + annualSalary2);
            bool isPerson1EarningMore = annualSalary1 > annualSalary2;

            Console.WriteLine("Does Person 1 make more money than Person 2? " + isPerson1EarningMore);
            Console.WriteLine(annualSalary1 > annualSalary2);
        }
    }
}
