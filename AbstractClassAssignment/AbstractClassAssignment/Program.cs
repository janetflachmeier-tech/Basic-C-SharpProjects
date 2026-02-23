using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object
            // Employee inherits from the abstract Person class
            Employee employee = new Employee();

            // Set the firstName property to "Sample"
            employee.firstName = "Sample";

            // Set the lastName property to "Student"
            employee.lastName = "Student";

            // Call the SayName() method on the employee object
            // This will display the employee's full name to the console
            employee.SayName();

            // Keep the console window open until user presses a key
            Console.ReadLine();
        }
    }
}
