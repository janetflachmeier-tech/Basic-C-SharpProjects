using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsandObjectsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate a new Person object
            Person person = new Person();
            
            // Set the FirstName property to "John"
            person.FirstName = "John";
            
            // Set the LastName property to "Doe"
            person.LastName = "Doe";

            // Display the full name using string interpolation
            Console.WriteLine($"Full Name: {person.FirstName} {person.LastName}");
            
            // Call the SayName() method to display the person's name in the console
            person.SayName();

            // Instantiate a new Employee object (which inherits from Person)
            Employee employee = new Employee();
            
            // Set the FirstName property to "Sample"
            employee.FirstName = "Sample";
            
            // Set the LastName property to "Student"
            employee.LastName = "Student";
            
            // Call the SayName() method inherited from Person class to display the employee's name
            employee.SayName();

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }

    // Define the Person class
    public class Person
    {
        // Auto-implemented property for storing the person's first name
        public string FirstName { get; set; }
        
        // Auto-implemented property for storing the person's last name
        public string LastName { get; set; }

        // Method to display the person's full name to the console
        public void SayName()
        {
            // Write the person's full name to the console in the format "Name: [FirstName] [LastName]"
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
    
    // Define the Employee class that inherits from Person class
    public class Employee : Person
    {
        // Auto-implemented property for storing the employee's ID number
        public int Id { get; set; }
    }
}
