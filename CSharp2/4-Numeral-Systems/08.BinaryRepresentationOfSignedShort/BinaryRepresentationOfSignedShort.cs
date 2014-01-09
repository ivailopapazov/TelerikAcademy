using System;
using Conversions;

class BinaryRepresentationOfSignedShort
{
    static string ShortBinaries(int decNumber)
    {
        // Binary holder
        string binaryHolder = string.Empty;

        // If number is positive
        if (decNumber >= 0)
        {
            // Calling conversion method from project 1
            binaryHolder = ConvertDecimalToBinary.ToBinary(decNumber);
            // Adding leading zeros
            binaryHolder = binaryHolder.PadLeft(16, '0');
        }
        // If number is negative
        else
        {
            // Negative number binary representation
            int negativeNumberRepresentation = 32768 + decNumber;

            // Converting to binary
            binaryHolder = ConvertDecimalToBinary.ToBinary(negativeNumberRepresentation);

            // Adding leading zeroes
            binaryHolder = binaryHolder.PadLeft(15, '0');

            // Adding binary representation of negative sign
            binaryHolder = binaryHolder.Insert(0, "1");
        }

        // Return holder
        return binaryHolder;
    }
    static void Main()
    {
        // User Input
        Console.Write("Enter a decimal number (from -32768 to 32767): ");
        int number = int.Parse(Console.ReadLine());

        // Get signed short binary representation
        string binaryRepresentation = ShortBinaries(number);

        // Print result 
        Console.WriteLine(binaryRepresentation);
    }
}

