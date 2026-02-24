using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    // Employee class implements the IQuittable interface
    // The colon (:) indicates inheritance/implementation
    // This means Employee must provide an implementation of all methods defined in IQuittable
    public class Employee : IQuittable
    {
        // Auto-implemented property for storing the employee's first name
        // get and set allow reading and writing the value
        public string FirstName { get; set; }
        
        // Auto-implemented property for storing the employee's last name
        public string LastName { get; set; }

        // Implementation of the Quit() method required by the IQuittable interface
        // This method defines what happens when an employee quits
        public void Quit()
        {
            // Display a message to the console indicating the employee has quit
            // Concatenates FirstName, a space, LastName, and a quit message
            Console.WriteLine(FirstName + " " + LastName + " has quit the job.");
        }
    }
}