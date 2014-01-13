using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class OddNumber
{
    static void Main()
    {
        int numberCount = int.Parse(Console.ReadLine());
        long[] numberSet = new long[numberCount];
        long result = 0;

        for (int i = 0; i < numberCount; i++)
        {
            numberSet[i] = long.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numberCount; i++)
        {
            result ^= numberSet[i];
        }
        Console.WriteLine(result);
    }
}
