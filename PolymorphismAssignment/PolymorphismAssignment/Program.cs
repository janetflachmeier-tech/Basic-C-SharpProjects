using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    internal class Program
    {
        static void Main(string[] args) // 'args' is required for the Main method signature
        {
            // Instantiate an Employee object and initialize its properties using object initializer syntax
            // This creates a new employee named John Doe
            Employee employee = new Employee { FirstName = "John", LastName = "Doe" };
            
            // Demonstrate polymorphism by assigning the Employee object to an IQuittable interface variable
            // This shows that an Employee can be treated as an IQuittable type
            // This is the key concept of polymorphism - using an interface reference to access implementing class
            IQuittable quittableEmployee = employee;
            
            // Call the Quit() method through the IQuittable interface
            // Even though we're using the interface type, it executes the Employee class's implementation
            quittableEmployee.Quit();

            // Keep the console window open until user presses Enter
            Console.ReadLine();
        }
    }
}
