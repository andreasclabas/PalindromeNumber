//
// Author: Andrea
// Date  : 01/03/2022 
//
// Task: Write a c# program to check palindrome number.

namespace PalindromeNumber
{
    internal class PalindromeNumber
    {
        /// <summary>
        /// Entry point of the program
        /// </summary>
        private static void Main()
        {
            bool firstCycle = true;
            string? input;
            do
            {
                // Error message visible only from the second cycle
                if (!firstCycle)
                {
                    Console.WriteLine("Invalid number! Retry or digit EXIT to close.");
                }

                // Ask how many numbers print
                Console.Write("Number to check: ");
                input = Console.ReadLine();

                // Exit condition
                if (input == "EXIT")
                    return;

                firstCycle = false;

                // Exit if a valid number has been provided
            } while (!int.TryParse(input, out _));

            // Obtain a reversed array of chars of the input value
            char[] reverseNumber = input.ToArray();
            Array.Reverse(reverseNumber);

            // If the string created with the inverted array is equal to the starting string then the number is palindrome 
            if (new string(reverseNumber) == input)
            {
                Console.WriteLine("Palindrome number");
            }
            else
            {
                Console.WriteLine("Non-palindrome number");
            }

        }
    }
}