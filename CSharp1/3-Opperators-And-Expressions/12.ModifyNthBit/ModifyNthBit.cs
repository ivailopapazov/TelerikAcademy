using System;

class Program
{
    static void Main()
    {
        Console.Write("Please enter number:");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Please enter bit position (starting from 0):");
        int bitPosition = int.Parse(Console.ReadLine());
        Console.Write("Please enter preferred value of the bit:");
        int bitValue = int.Parse(Console.ReadLine());

        int some = bitValue == 1 ? number | (1 << bitPosition) : number & ~(1 << bitPosition);
        Console.WriteLine(some);
    }
}
