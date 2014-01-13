using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SubsetSums
{
    static void Main()
    {
        long subsetSum = long.Parse(Console.ReadLine());
        int numberCount = int.Parse(Console.ReadLine());
        long[] numberSet = new long[numberCount];
        int combination = 0;
        List<long> subset = new List<long>();
        int subsetCount = 0;


        for (int i = 0; i < numberCount; i++)
        {
            numberSet[i] = long.Parse(Console.ReadLine());
        }

        for (int i = 1; i < (1 << numberCount) ; i++)
        {
            combination = i;
            for (int j = 0; combination > 0; j++)
            {
                if (combination % 2 == 1)
                {
                    subset.Add(numberSet[j]);
                }
                combination >>= 1;
            }
            if (subset.Sum() == subsetSum)
            {
                subsetCount++;
            }
            subset.Clear();
        }
        Console.WriteLine(subsetCount);
    }
}
