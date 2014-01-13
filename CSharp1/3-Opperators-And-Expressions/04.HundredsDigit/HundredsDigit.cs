using System;

class HundredsDigit
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());
        bool isSeven = ((number / 100) % 10) == 7;
        Console.WriteLine("The hundreds digit in number {0} {1} 7", number, isSeven ? "is" : "is not");
    }
}
