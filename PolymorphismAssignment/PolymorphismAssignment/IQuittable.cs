using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    // Interface definition for IQuittable
    // Interfaces define a contract that implementing classes must follow
    // They contain method signatures without implementations
    interface IQuittable
    {
        // Method signature for Quit() - returns void (nothing)
        // Any class implementing IQuittable must provide their own implementation of this method
        void Quit();
    }
}