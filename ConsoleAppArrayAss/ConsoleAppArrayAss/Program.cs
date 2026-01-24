using System;
using System.Collections.Generic;

partial class Program
{
    static void Main()
    {
        // -------------------------------
        // 1. Create a one-dimentional Array of strings
        // -------------------------------
        string[] stringArray = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

        Console.WriteLine("Select a number between (0 to 4) to view a fruit from the array:");
        int stringSelect = Convert.ToInt32(Console.ReadLine());
        bool validString = false;

        // Check if index is within bounds
        while (!validString)
        {
            try
            {
                Console.WriteLine("You selected: " + stringArray[stringSelect]);
                validString = true;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Error: Index does not exist in the string array.");
                Console.WriteLine("Please enter a valid number between 0 and 4:");
                string input = Console.ReadLine();
                if (int.TryParse(input, out stringSelect))
                {
                    // Parsed successfully, will retry in next loop iteration
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }
       
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }

        // -------------------------------
        // 2. Create a one-dimensional array of integers
        // -------------------------------
        int[] intArray = { 10, 20, 30, 40, 50 };

        Console.WriteLine("\nSelect an index (0 to 4) to view a number from the array:");
        string inputIntIndex = Console.ReadLine();

        if (int.TryParse(inputIntIndex, out int intIndex))
        {
            if (intIndex >= 0 && intIndex < intArray.Length)
            {
                Console.WriteLine($"You selected: {intArray[intIndex]}");
            }
            else
            {
                Console.WriteLine("Error: Index does not exist in the integer array.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }

        // -------------------------------
        // 3. Create a list of strings
        // -------------------------------
        List<string> stringList = new List<string> { "Red", "Green", "Blue", "Yellow", "Purple" };

        Console.WriteLine("\nSelect an index (0 to 4) to view a color from the list:");
        string inputListIndex = Console.ReadLine();

        if (int.TryParse(inputListIndex, out int listIndex))
        {
            if (listIndex >= 0 && listIndex < stringList.Count)
            {
                Console.WriteLine($"You selected: {stringList[listIndex]}");
            }
            else
            {
                Console.WriteLine("Error: Index does not exist in the list.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }

        // -------------------------------
        // End of program
        // -------------------------------
        Console.WriteLine("\nProgram finished. Press any key to exit.");
        Console.ReadKey();
    }
}
