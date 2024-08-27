// Date: 2024-08-27
// Author: Mayank Sharma
/** 
*   Completed - Arrays may not be used to contain the binary digits entered by the user
*   Completed - Determining the decimal equivalent of a particular binary digit in the sequence must be calculated 
*   using a single mathematical function, for example the natural logarithm. 
*   It's up to you to figure out which function to use.
*   Completed - User can enter up to 8 binary digits in one input field
*   User must be notified if anything other than a 0 or 1 was entered
*   Completed - User views the results in a single output field containing the decimal (base 10) 
*   equivalent of the binary number that was entered
*   Completed - User can enter a variable number of binary digits
**/

using System;
using System.Collections;
using System.Numerics;

namespace bin_2_dec_app
{
    class Program
    {
        private const int MAX_BINARY_INPUT_LENGTH = 8;
        private const int MIN_BINARY_INPUT_LENGTH = 0;
        static void Main()
        {
            Console.WriteLine("Enter a binary number: ");
            int Output = 0;
            string BinaryNumber = Console.ReadLine();

            if (BinaryNumber?.Length > MIN_BINARY_INPUT_LENGTH 
            && BinaryNumber?.Length <= MAX_BINARY_INPUT_LENGTH) 
            {
                for(int i = 0; i < BinaryNumber?.Length - 1; i++)
                {
                    Output += (int)(Math.Pow(2, (double)(BinaryNumber?.Length - 1 - i)) * char.GetNumericValue(BinaryNumber[i]));
                    Console.WriteLine(Output);
                }

                Console.WriteLine(Output);

            }
            else 
            {
                Console.WriteLine("No number was entered or the number entered was longer than 8 digits");
            }
        }
    }
}