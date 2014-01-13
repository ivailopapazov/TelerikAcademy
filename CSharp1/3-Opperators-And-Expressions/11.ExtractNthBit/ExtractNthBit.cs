using System;

class ExtractNthBit
{
    static void Main()
    {
        Console.Write("Please enter number:");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Please enter bit position (starting from 0):");
        int position = int.Parse(Console.ReadLine());

        // Method without mask
        int some = (number >> position) % 2;
        Console.WriteLine(some);
    }
}
