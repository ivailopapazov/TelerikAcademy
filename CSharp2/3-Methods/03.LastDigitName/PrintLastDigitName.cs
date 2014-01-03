using System;

class PrintLastDigitName
{
    static string LastDigitName(int number)
    {
        switch (number % 10)
        {
            case 0:
                return "Zero";
            case 1:
                return "One";
            case 2:
                return "Two";
            case 3:
                return "Three";
            case 4:
                return "Four";
            case 5:
                return "Five";
            case 6:
                return "Six";
            case 7:
                return "Seven";
            case 8:
                return "Eight";
            case 9:
                return "Nine";
            default:
                return string.Empty;
        }
    }
    static void Main()
    {
        // User Input
        Console.Write("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Calling LastDigitName Method
        string digitName = LastDigitName(number);

        // Printing Result
        Console.WriteLine(digitName);
    }
}
