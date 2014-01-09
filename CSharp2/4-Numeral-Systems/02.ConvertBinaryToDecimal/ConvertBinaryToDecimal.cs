using System;
using CustomTools;

class ConvertBinaryToDecimal
{
    static int ToDecimal(string binNum)
    {
        // Decimal number container
        int decNum = 0;

        // Converting to decimal
        for (int i = 0; i < binNum.Length; i++)
        {
            // Continue when current bit is equal to 0
            if (binNum[i] == '1')
            {
                // Bit position
                int bitPos = binNum.Length - 1 - i;

                // Summing bit values
                decNum += CustomMath.FastPow(2, bitPos);
            }
        }

        // Return decimal number
        return decNum;
    }
    static void Main()
    {
        // User Input
        Console.Write("Please enter binary number: ");
        string binaryNumber = Console.ReadLine();

        // Convert to decimal
        int decimalNumber = ToDecimal(binaryNumber);

        // Print Result
        Console.WriteLine(decimalNumber);
    }
}
