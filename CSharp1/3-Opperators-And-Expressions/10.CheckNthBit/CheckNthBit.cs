using System;

class CheckNthBit
{
    static void Main()
    {
        Console.Write("Please enter number:");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Please enter bit position (starting from 0):");
        int position = int.Parse(Console.ReadLine());

        // Method using mask
        int mask = 1 << position;
        bool some = ((number & mask) >> position) == 1;
        Console.WriteLine(some);

    }
}
