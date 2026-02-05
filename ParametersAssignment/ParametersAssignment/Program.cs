using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    // Define a generic Employee class that can work with any type T
    public class Employee<T>
    {
        // Property to store the employee's first name
        public string FirstName { get; set; }
        
        // Property to store the employee's last name
        public string LastName { get; set; }
        
        // Property to store the employee's ID number
        public int Id { get; set; }
        
        // Property to store a list of items of type T (generic type parameter)
        public List<T> Things { get; set; }

        // Constructor that initializes the Things list as an empty list
        public Employee()
        {
            Things = new List<T>();
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Employee with string as the generic type parameter
            Employee<string> stringEmployee = new Employee<string>();
            
            // Set the first name property
            stringEmployee.FirstName = "John";
            
            // Set the last name property
            stringEmployee.LastName = "Student";
            
            // Set the ID property
            stringEmployee.Id = 1;
            
            // Add string items to the Things list
            stringEmployee.Things.Add("Book");
            stringEmployee.Things.Add("Laptop");
            stringEmployee.Things.Add("Pen");

            // Create an instance of Employee with int as the generic type parameter
            Employee<int> intEmployee = new Employee<int>();
            
            // Set the first name property
            intEmployee.FirstName = "Jane";
            
            // Set the last name property
            intEmployee.LastName = "Worker";
            
            // Set the ID property
            intEmployee.Id = 2;
            
            // Assign a new list of integers to the Things property
            intEmployee.Things = new List<int> { 1, 2, 3, 4, 5 };

            // Display the string employee's information to the console
            Console.WriteLine("Employee Details:");
            Console.WriteLine($"Name: {stringEmployee.FirstName} {stringEmployee.LastName}");
            Console.WriteLine($"ID: {stringEmployee.Id}");
            Console.WriteLine("Things:");
            
            // Loop through each string item in the stringEmployee's Things list and print it
            foreach (var thing in stringEmployee.Things)
            {
                Console.WriteLine($"- {thing}");
            }

            // Add a blank line for better readability between the two employee outputs
            Console.WriteLine();

            // Display the int employee's information to the console
            Console.WriteLine("Employee Details:");
            Console.WriteLine($"Name: {intEmployee.FirstName} {intEmployee.LastName}");
            Console.WriteLine($"ID: {intEmployee.Id}");
            Console.WriteLine("Things:");
            
            // Loop through each integer item in the intEmployee's Things list and print it
            foreach (var thing in intEmployee.Things)
            {
                Console.WriteLine($"- {thing}");
            }

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}
