using System;
using System.Text;

namespace Conversions
{
    public class ConvertDecimalToBinary
    {
        public static string ToBinary(int decimalNumber)
        {
            // Zero case
            if (decimalNumber == 0)
            {
                return "0";
            }

            // Container for binary representation
            string binaryHolder = string.Empty;

            // Short division by two with remainder
            while (decimalNumber != 0)
            {
                // Taking the remainder
                int remainder = decimalNumber % 2;
                // Short division by two
                decimalNumber /= 2;
                // Store the remainder
                binaryHolder += remainder;
            }

            // Create char array
            char[] binaryArray = binaryHolder.ToCharArray();

            // Reverse char array
            Array.Reverse(binaryArray);

            // Convert char array to string
            string binaryNumber = new string(binaryArray);

            // Return binary number
            return binaryNumber;
        }
        static void Main()
        {
            // User Input
            Console.Write("Please enter decimal number: ");
            int decimalNumber = int.Parse(Console.ReadLine());

            // Convert to Binary
            string binaryNumber = ToBinary(decimalNumber);

            // Print Result
            Console.WriteLine(binaryNumber);
        }
    }
}