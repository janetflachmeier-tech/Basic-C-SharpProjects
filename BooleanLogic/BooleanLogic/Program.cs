using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(true && true && true || false);// Output: True
            //Console.WriteLine(true && true);// Output: True
            //Console.WriteLine(false && false);// Output: False

            //Console.WriteLine(true || true);// Output: True
            //Console.WriteLine(true || false);// Output: True
            //Console.WriteLine(false || false);// Output: False

            //Console.WriteLine(true == true);// Output: True
            //Console.WriteLine(true == false);// Output: False
            //Console.WriteLine(false == false);// Output: True

            //Console.WriteLine(true != true);// Output: False
            //Console.WriteLine(true != false);// Output: True
            //Console.WriteLine(false != false);// Output: False

            //Console.WriteLine(true ^ true);// Output: False
            //Console.WriteLine(true ^ false);// Output: True
            //Console.WriteLine(false ^ false);// Output: False

            Console.ReadLine();

   


        }
    }
}
