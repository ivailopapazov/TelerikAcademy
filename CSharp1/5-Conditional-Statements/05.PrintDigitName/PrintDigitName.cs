using System;

class PrintDigitName
{
    static void Main()
    {
        Console.Write("Please enter digit: ");
        int digit = int.Parse(Console.ReadLine());
        string digitName = "";

        // Nothing to say here too
        switch(digit)
        {
            case 0:
                digitName = "Zero";
                break;
            case 1:
                digitName = "One";
                break;
            case 2:
                digitName = "Two";
                break;
            case 3:
                digitName = "Three";
                break;
            case 4:
                digitName = "Four";
                break;
            case 5:
                digitName = "Five";
                break;
            case 6:
                digitName = "Six";
                break;
            case 7:
                digitName = "Seven";
                break;
            case 8:
                digitName = "Eight";
                break;
            case 9:
                digitName = "Nine";
                break;
            default:
                digitName = "Not a digit";
                break;
        }
        Console.WriteLine(digitName);
    }
}
