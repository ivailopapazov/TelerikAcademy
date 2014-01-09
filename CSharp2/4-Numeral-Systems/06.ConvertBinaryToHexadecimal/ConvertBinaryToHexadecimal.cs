using System;

class ConvertBinaryToHexadecimal
{
    static string ToHexDigit(string bitGroup)
    {
        switch (bitGroup)
        {
            case "0000":
                return "0";
            case "0001":
                return "1";
            case "0010":
                return "2";
            case "0011":
                return "3";
            case "0100":
                return "4";
            case "0101":
                return "5";
            case "0110":
                return "6";
            case "0111":
                return "7";
            case "1000":
                return "8";
            case "1001":
                return "9";
            case "1010":
                return "A";
            case "1011":
                return "B";
            case "1100":
                return "C";
            case "1101":
                return "D";
            case "1110":
                return "E";
            case "1111":
                return "F";
            default:
                throw new ArgumentException("Invalid nibble");
        }
    }
    static string BinaryToHex(string binNum)
    {
        // Hexadecimal number container
        string hexNum = string.Empty;

        // Adding leading zeros if necessary
        if (binNum.Length % 4 != 0)
        {
            int leadingZeros = 4 - binNum.Length % 4;
            binNum = binNum.PadLeft(leadingZeros + binNum.Length, '0');
        }

        // Convert binary to hex
        for (int i = 0; i < binNum.Length; i += 4)
        {
            // Taking four bit groups
            string nibble = binNum.Substring(i, 4);

            // Convert four bit group to hex digit
            hexNum += ToHexDigit(nibble);
        }

        // Return Hexadecimal Number
        return hexNum;
    }
    static void Main()
    {
        // User Input
        Console.Write("Please enter binary number: ");
        string binaryNumber = Console.ReadLine();

        // Convert Binary to Hexadecimal
        string hexadecimalNumber = BinaryToHex(binaryNumber);

        // Print result
        Console.WriteLine(hexadecimalNumber);
    }
}
