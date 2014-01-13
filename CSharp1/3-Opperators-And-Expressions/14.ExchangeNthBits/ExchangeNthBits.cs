using System;

class ExchangeNthBits
{
    static void Main()
    {
        Console.Write("Please enter number:");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Please enter first group bit:");
        int firstGroupBit = int.Parse(Console.ReadLine());
        Console.Write("Please enter second group bit:");
        int secondGroupBit = int.Parse(Console.ReadLine());
        Console.Write("Please enter how much bits to exchange:");
        int bitCount = int.Parse(Console.ReadLine());

        int result = number;
        int p, k;

        for (int i = 0; i < bitCount; i++)
        {
            p = firstGroupBit + i;
            k = secondGroupBit + i;
            result = ((number >> p) % 2) == 1 ? result | (1 << k) : result & ~(1 << k);
            result = ((number >> k) % 2) == 1 ? result | (1 << p) : result & ~(1 << p);
        }

        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
    }
}
