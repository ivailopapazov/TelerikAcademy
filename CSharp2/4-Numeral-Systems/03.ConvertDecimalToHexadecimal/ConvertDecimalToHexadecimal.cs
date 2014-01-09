using System;
using System.Collections.Generic;

class ConvertDecimalToHexadecimal
{
    static string ToHexDigit(int decNum)
    {
        // Return string representation of decimal digit
        if (decNum >= 0 && decNum < 10)
        {
            return decNum.ToString();
        }
        // Return hexadecimal digit for decNum > 9 && decNum < 16
        else
        {
            switch (decNum)
            {
                case 10:
                    return "A";
                case 11:
                    return "B";
                case 12:
                    return "C";
                case 13:
                    return "D";
                case 14:
                    return "E";
                case 15:
                    return "F";
                default:
                    throw new ArgumentException("Cannot convert to hexadecimal digit");
            }
        }
    }
    static string ToHexNumber(int decNum)
    {
        // Zero case
        if (decNum == 0)
        {
            return "0";
        }

        // Hexadeicmal number container
        List<string> hexNum = new List<string>();

        // Short division by 16 with remainder
        while (decNum != 0)
        {
            // Taking remainder
            int remainder = decNum % 16;
            // Convert remainder to hexadecimal digit
            string hexDigit = ToHexDigit(remainder);
            // Adding digit to container
            hexNum.Add(hexDigit);
            // Short division by 16
            decNum /= 16;
        }

        // Reverse the list of hex digits
        hexNum.Reverse();

        // Convert to string and return
        return string.Join(string.Empty, hexNum);
    }
    static void Main()
    {
        // User Input
        Console.Write("Please enter decimal number: ");
        int decimalNumber = int.Parse(Console.ReadLine());

        // Convert Decimal to Hexadecimal
        string hexadecimalNumber = ToHexNumber(decimalNumber);

        // Printing Result
        Console.WriteLine(hexadecimalNumber);
    }
}
