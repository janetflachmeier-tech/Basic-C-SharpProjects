using System;
using System.Collections.Generic;

namespace ConsoleAppAssignmentPart1
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Assignment Part 1
            // Create a one-dimensional array of strings
            string[] stringArray = { "Hello", "Good morning", "Welcome", "Greetings", "Hi there" };

            // Ask the user to input some text
            Console.WriteLine("Please enter your name to append to each string:");
            string userInput = Console.ReadLine();

            // Loop through each string in the array and append the user's text
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = stringArray[i] + userInput;
            }

            // Loop through the array and print each string
            Console.WriteLine("\nUpdated strings:");
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }

            //Assignment Part 2

            // INFINITE LOOP EXAMPLE (FIXED):
            // The original infinite loop was: for (int j = 0; j < 10; j--) 
            // This caused an infinite loop because j was decremented instead of incremented,
            // so j would never reach 10 (it would go negative and continue forever).
            // FIX: Changed j-- to j++ so the counter increments properly and reaches the exit condition.
            Console.WriteLine("\nCounting from 0 to 9:");
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine("Count: " + j);
            }


            //Assignment Part 3

            // Loop using "<" operator: iterates while k is less than 5 (stops when k equals 5)
            // This loop will execute for k = 0, 1, 2, 3, 4 (5 iterations total)
            Console.WriteLine("\nLoop using '<' operator (k < 5):");
            for (int k = 0; k < 5; k++)
            {
                Console.WriteLine("k = " + k);
            }

            // Loop using "<=" operator: iterates while m is less than or equal to 5 (stops when m is greater than 5)
            // This loop will execute for m = 0, 1, 2, 3, 4, 5 (6 iterations total)
            Console.WriteLine("\nLoop using '<=' operator (m <= 5):");
            for (int m = 0; m <= 5; m++)
            {
                Console.WriteLine("m = " + m);
            }

            //Assignment Part 4

            // Create a list of strings where each item is unique
            List<string> uniqueList = new List<string> { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

            // Display the list to the user
            Console.WriteLine("\nList of fruits:");
            for (int n = 0; n < uniqueList.Count; n++)
            {
                Console.WriteLine(n + ": " + uniqueList[n]);
            }

            // Ask the user to input text to search for in the list
            Console.WriteLine("\nPlease enter a fruit name to search for:");
            string searchText = Console.ReadLine();

            // Variable to track if a match was found
            bool foundMatch = false;

            // Loop through the list to find matching text
            for (int n = 0; n < uniqueList.Count; n++)
            {
                if (uniqueList[n].Equals(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    // Display the index of the matching item
                    Console.WriteLine("Match found at index: " + n);
                    foundMatch = true;
                    // Stop the loop once a match is found
                    break;
                }
            }

            // Check if no match was found and inform the user
            if (!foundMatch)
            {
                Console.WriteLine("Your input is not on the list.");
            }

            //Assignment Part 5

            // Create a list of strings with at least two identical strings
            List<string> duplicateList = new List<string> { "Red", "Blue", "Green", "Blue", "Yellow", "Red", "Purple", "Green" };

            // Display the list to the user
            Console.WriteLine("\n\nList of colors:");
            for (int p = 0; p < duplicateList.Count; p++)
            {
                Console.WriteLine(p + ": " + duplicateList[p]);
            }

            // Ask the user to select text to search for in the list
            Console.WriteLine("\nPlease enter a color name to search for:");
            string searchColor = Console.ReadLine();

            // Variable to track if a match was found
            bool foundMatchInDuplicates = false;

            // Loop through the list to find all matching text
            // Note: No break statement is used, so the loop continues through the entire list
            for (int p = 0; p < duplicateList.Count; p++)
            {
                if (duplicateList[p].Equals(searchColor, StringComparison.OrdinalIgnoreCase))
                {
                    // Display the index of each matching item
                    Console.WriteLine("Match found at index: " + p);
                    foundMatchInDuplicates = true;
                    // No break statement - loop continues to find all matches
                }
            }

            // Check if no match was found and inform the user
            if (!foundMatchInDuplicates)
            {
                Console.WriteLine("Your input is not on the list.");
            }

            
            //Assignment Part 6

            // Create a list of strings with at least two identical strings
            // This list contains animals, with "Cat" and "Dog" appearing twice each
            List<string> animalList = new List<string> { "Cat", "Dog", "Bird", "Cat", "Fish", "Dog", "Hamster" };

            // Create a list to track which strings have already been encountered
            // This list will store strings that we've already seen as we iterate through animalList
            List<string> seenItems = new List<string>();

            // Display a header for the duplicate check section
            Console.WriteLine("\n\nChecking for duplicates in the animal list:");

            // Use a foreach loop to iterate through each item in the animalList
            // The foreach loop automatically retrieves each element without needing an index
            foreach (string animal in animalList)
            {
                // Check if the current animal string has already been encountered
                // The Contains method returns true if the item exists in the seenItems list
                if (seenItems.Contains(animal))
                {
                    // If the animal is already in seenItems, it's a duplicate
                    Console.WriteLine(animal + " - this item is a duplicate");
                }
                else
                {
                    // If the animal is not in seenItems, it's the first occurrence (unique so far)
                    Console.WriteLine(animal + " - this item is unique");

                    // Add the current animal to the seenItems list so we can track it
                    // for future iterations of the loop
                    seenItems.Add(animal);
                }
            }

            // Keep console window open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}