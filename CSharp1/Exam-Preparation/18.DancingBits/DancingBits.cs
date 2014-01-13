using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DancingBits
{
    static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int dancingBit = -1;
        int bitReps = 0;
        int dancingBitsCount = 0;

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            int firstSignificantBit = 0;
            // Iterate leading zeroes and find MSB position
            for (int j = 31; j >= 0; j--)
            {
                if ((number & (1 << j)) != 0)
                {
                    firstSignificantBit = j;
                    break;
                }
            }
            // Iterate number until last bit
            for (int j = firstSignificantBit; j >= 0; j--)
            {
                int currentBit = (number >> j) & 1;
                //Console.Write(currentBit);

                if (currentBit == dancingBit) // Bit toggle
                {
                    bitReps++;
                }
                else // Bit sequence
                {
                    if (bitReps == k)
                    {
                        dancingBitsCount++;
                        //Console.Write("-DANCE-");
                    }
                    bitReps = 1;
                }
                dancingBit = currentBit;
            }
        }
        if (bitReps == k)
        {
            dancingBitsCount++;
        }
        Console.WriteLine(dancingBitsCount);
    }
}
