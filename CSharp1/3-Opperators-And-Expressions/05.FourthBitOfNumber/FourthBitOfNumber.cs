using System;

class FourthBitOfNumber
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());
        bool fourthBit = ((number >> 3) % 2) == 1; // True if 1 or False if 0
        Console.WriteLine("Bit 3 (counting from 0) in number {0} is {1}", number, fourthBit ? 1 : 0);
    }
}
