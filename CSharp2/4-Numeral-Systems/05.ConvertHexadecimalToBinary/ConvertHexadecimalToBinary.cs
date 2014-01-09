using System;

class ConvertHexadecimalToBinary
{
    static string HexDigitToBinary(char hexDigit)
    {
        switch (hexDigit)
        {
            case '0':
                return "0000";
            case '1':
                return "0001";
            case '2':
                return "0010";
            case '3':
                return "0011";
            case '4':
                return "0100";
            case '5':
                return "0101";
            case '6':
                return "0110";
            case '7':
                return "0111";
            case '8':
                return "1000";
            case '9':
                return "1001";
            case 'A':
                return "1010";
            case 'B':
                return "1011";
            case 'C':
                return "1100";
            case 'D':
                return "1101";
            case 'E':
                return "1110";
            case 'F':
                return "1111";
            default:
                throw new ArgumentException("Not a hexadecimal digit");
        }
    }
    static string HexToBinary(string hexNum)
    {
        // Zero Case
        if (hexNum == "0")
        {
            return "0";
        }

        // Binary number container
        string binNum = string.Empty;

        // Converting Hexadecimal number to binary number
        for (int i = 0; i < hexNum.Length; i++)
        {
            binNum += HexDigitToBinary(hexNum[i]);
        }
        
        // Get most significant bit that is equal to one
        int firstMSB = binNum.IndexOf('1');

        // Remove leading zeros
        binNum = binNum.Substring(firstMSB);

        // Returning binary number
        return binNum;
    }
    static void Main()
    {
        // User Input
        Console.Write("Please enter hexadecimal number: ");
        string hexadecimalNumber = Console.ReadLine();

        // Converting Hexadecimal to Binary
        string binaryNumber = HexToBinary(hexadecimalNumber);

        // Printing Result
        Console.WriteLine(binaryNumber);
    }
}
