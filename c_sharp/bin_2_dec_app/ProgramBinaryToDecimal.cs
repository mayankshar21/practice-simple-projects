// Date: 2024-08-27
// Author: Mayank Sharma
/** 
*   Arrays may not be used to contain the binary digits entered by the user
*   Determining the decimal equivalent of a particular binary digit in the sequence must be calculated 
*   using a single mathematical function, for example the natural logarithm. 
*   It's up to you to figure out which function to use.
*   User can enter up to 8 binary digits in one input field
*   User must be notified if anything other than a 0 or 1 was entered
*   User views the results in a single output field containing the decimal (base 10) 
*   equivalent of the binary number that was entered
*   User can enter a variable number of binary digits
**/

namespace bin_2_dec_app
{
    class ProgramBinaryToDecimal
    {
        static void Main()
        {
            Console.WriteLine("Please enter a binary number with up to 8 digits:");
            string BinaryNumber = Console.ReadLine();

            CheckNumberLengthIsEightorLess(BinaryNumber);        
            CheckDigitsAreOnlyZeroAndOne(BinaryNumber);
            Console.WriteLine(BinaryToDecimalMathematicalFunction(BinaryNumber));
        }

        public static double BinaryToDecimalMathematicalFunction(string BinaryNumber) 
        {
            double Output = 0;

            // variable number of binary digits
            for (int i = 0; i < BinaryNumber?.Length; i++)
            {
                // single mathematical function
                // eg: 1101 = 2 ^ 3 * 1 + 2 ^ 2 * 1 + 2 ^ 1 * 0 + 2 ^ 0 * 1 = 13
                Output += Math.Pow(2, (double)BinaryNumber.Length - 1 - i) * char.GetNumericValue(BinaryNumber[i]);
                            
            }
            
            return Output;
        }

        public static void CheckDigitsAreOnlyZeroAndOne(string BinaryNumber) 
        {
             // check if any other number other than 0 or 1 is entered
            for (int i = 0; i < BinaryNumber?.Length; i++)
            {
                double Digit = char.GetNumericValue(BinaryNumber[i]);
                if (Digit > 1 || Digit < 0) 
                {
                    Console.WriteLine("Binary number entered contains a digit greater than 1 or less than 0");
                    Environment.Exit(1);
                }
                            
            }
            
        }

        public static void CheckNumberLengthIsEightorLess(string BinaryNumber)
        {
            // check if binary number less than 8 and greater than 1 was entered
            if (BinaryNumber == null || BinaryNumber?.Length is not <= 8 or not > 0)
            {
                Console.WriteLine("Binary number of length greater than 8 or less than 1 was entered!");
                Environment.Exit(1);
            }
        }
    }
}