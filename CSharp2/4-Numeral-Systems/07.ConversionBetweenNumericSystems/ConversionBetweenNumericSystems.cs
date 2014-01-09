using CustomTools;
using System;
using System.Collections.Generic;
using System.Text;

class ConversionBetweenNumericSystems
{
    static char GetValueDigit(int value)
    {
        char digit = new char();

        if (value < 10)
        {
            digit = (char)('0' + value);
        }
        else
        {
            digit = (char)(55 + value); // '0' + 7 symbols = 55
        }

        return digit;
    }
    static string FromDecimal(int number, int radix)
    {
        // Decimal Case
        if (radix == 10)
        {
            return number.ToString();
        }

        // Converted number container
        List<char> convertedNumber = new List<char>();

        // Converting with short division by radix with remainder
        while (number != 0)
        {
            // Get the remainder from short division
            int remainder = number % radix;

            // Make short division
            number /= radix;
            
            // Convert remainder to coresponding digit
            char digit = GetValueDigit(remainder);

            // Store digit in list
            convertedNumber.Add(digit);
        }

        // Reverse list
        convertedNumber.Reverse();

        // Return converted decimal
        return string.Join("", convertedNumber);
    }
    static int GetDigitValue(char digit)
    {
        int digitValue = 0;

        if (digit > '9') 
        {
            // Remove ascii sybmols from 58 to 64
            digitValue = digit - '0' - 7;
        }
        else
        {
            // Direct digit conversion
            digitValue = digit - '0';
        }

        return digitValue;
    }
    static int ToDecimal(string numeric, int radix)
    {
        // Check for decimal input
        if (radix == 10)
        {
            return int.Parse(numeric);
        }

        // Decimal Number Container
        int decNum = 0;

        // Convert To Decimal
        for (int i = 0; i < numeric.Length; i++)
        {
            // Skip zero digits
            if (numeric[i] == '0')
            {
                continue;
            }

            // Taking digit position
            int digitPosition = numeric.Length - 1 - i;

            // Taking digit value
            int digitValue = GetDigitValue(numeric[i]);

            // Adding position value to result
            decNum += digitValue * CustomMath.FastPow(radix, digitPosition);
        }

        // Return Decimal Number
        return decNum;
    }
    static void Main()
    {
        // User Input
        Console.Write("Convert from numeral system with base: ");
        int convertFrom = int.Parse(Console.ReadLine());
        Console.Write("Convert to numeral system with base: ");
        int convertTo = int.Parse(Console.ReadLine());
        Console.Write("Enter a number: ");
        string number = Console.ReadLine();

        // Convert to decimal
        int decimalNumber = ToDecimal(number, convertFrom);

        // Convert from decimal
        string convertedNumber = FromDecimal(decimalNumber, convertTo);

        // Printing result
        Console.WriteLine(convertedNumber);
    }
}
