using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create the first Employee object with Id of 1
            Employee employee1 = new Employee
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe"
            };

            // Create the second Employee object with Id of 2
            Employee employee2 = new Employee
            {
                Id = 2,
                FirstName = "Jane",
                LastName = "Smith"
            };

            // Create the third Employee object with Id of 1 (same as employee1)
            // This will test that the == operator compares by Id, not by reference or other properties
            Employee employee3 = new Employee
            {
                Id = 1,
                FirstName = "Bob",
                LastName = "Johnson"
            };

            // Display comparison results for employee1 and employee2
            Console.WriteLine("Comparing Employee 1 and Employee 2:");
            
            // Show employee1's details
            Console.WriteLine($"Employee 1 ID: {employee1.Id}, Name: {employee1.FirstName} {employee1.LastName}");
            
            // Show employee2's details
            Console.WriteLine($"Employee 2 ID: {employee2.Id}, Name: {employee2.FirstName} {employee2.LastName}");
            
            // Use the overloaded == operator to check equality (should be False - different Ids)
            Console.WriteLine($"Are they equal? {employee1 == employee2}");
            
            // Use the overloaded != operator to check inequality (should be True - different Ids)
            Console.WriteLine($"Are they not equal? {employee1 != employee2}");
            
            // Add blank line for readability
            Console.WriteLine();

            // Display comparison results for employee1 and employee3
            Console.WriteLine("Comparing Employee 1 and Employee 3:");
            
            // Show employee1's details
            Console.WriteLine($"Employee 1 ID: {employee1.Id}, Name: {employee1.FirstName} {employee1.LastName}");
            
            // Show employee3's details
            Console.WriteLine($"Employee 3 ID: {employee3.Id}, Name: {employee3.FirstName} {employee3.LastName}");
            
            // Use the overloaded == operator to check equality (should be True - same Id)
            Console.WriteLine($"Are they equal? {employee1 == employee3}");
            
            // Use the overloaded != operator to check inequality (should be False - same Id)
            Console.WriteLine($"Are they not equal? {employee1 != employee3}");

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}
