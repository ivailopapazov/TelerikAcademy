using CustomTools;
using System;

class ConvertHexadecimalToDecimal
{
    static int HexDigitValue(char hexDigit)
    {
        if (hexDigit >= '0' && hexDigit <= '9')
        {
            return hexDigit - '0';
        }
        else
        {
            switch (hexDigit)
            {
                case 'A':
                    return 10;
                case 'B':
                    return 11;
                case 'C':
                    return 12;
                case 'D':
                    return 13;
                case 'E':
                    return 14;
                case 'F':
                    return 15;
                default:
                    throw new ArgumentException("Not a hexadecimal digit");
            }
        }
    }
    static int HexToDec(string hexNum)
    {
        // Decimal number container
        int decNum = 0;

        // Converting to decimal
        for (int i = 0; i < hexNum.Length; i++)
        {
            // Continue when current digit is equal to 0
            if (hexNum[i] == '0')
            {
                continue;
            }

            // Digit value
            int digitValue = HexDigitValue(hexNum[i]);

            // Digit position
            int digitPos = hexNum.Length - 1 - i;

            // Summing result
            decNum += digitValue * CustomMath.FastPow(16, digitPos);
        }

        // Return decimal number
        return decNum;
    }
    static void Main()
    {
        // User Input
        Console.Write("Please enter hexadecimal number: ");
        string hexadecimalNumber = Console.ReadLine();

        // Convert Hexadecimal to Decimal
        int decimalNumber = HexToDec(hexadecimalNumber);

        // Printing Result
        Console.WriteLine(decimalNumber);
    }
}
