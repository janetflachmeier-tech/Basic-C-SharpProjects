using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    // Employee class represents an employee with basic identification properties
    public class Employee
    {
        // Unique identifier for the employee
        public int Id { get; set; }
        
        // Employee's first name
        public string FirstName { get; set; }
        
        // Employee's last name
        public string LastName { get; set; }

        // Overload the == operator to compare two Employee objects
        // Returns true if both employees have the same Id, false otherwise
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Check if both references point to the same object (including both null)
            if (ReferenceEquals(emp1, emp2))
            {
                return true;
            }

            // Check if either employee is null (but not both, since that was handled above)
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
            {
                return false;
            }

            // Compare the Id properties of both employees
            return emp1.Id == emp2.Id;
        }

        // Overload the != operator (must be paired with ==)
        // Returns true if employees have different Ids, false if they're equal
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Use the negation of the == operator to determine inequality
            return !(emp1 == emp2);
        }

        // Override the Equals method for consistency with == operator
        // This ensures .Equals() behaves the same as the == operator
        public override bool Equals(object obj)
        {
            // Check if the object is null or not an Employee type
            if (obj == null || !(obj is Employee))
            {
                return false;
            }

            // Cast the object to Employee type
            Employee other = (Employee)obj;
            
            // Compare the Id of this employee with the other employee's Id
            return this.Id == other.Id;
        }

        // Override GetHashCode to maintain the contract with Equals
        // Objects that are equal must return the same hash code
        public override int GetHashCode()
        {
            // Return the hash code of the Id property
            return Id.GetHashCode();
        }
    }
}