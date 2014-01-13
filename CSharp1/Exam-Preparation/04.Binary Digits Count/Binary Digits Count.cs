using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int needle = int.Parse(Console.ReadLine());
        int numberCount = int.Parse(Console.ReadLine());
        int[] result = new int[numberCount];
        long haystack = 0;

        for (int i = 0; i < numberCount; i++)
        {
            haystack = long.Parse(Console.ReadLine());
            while (haystack != 0)
            {
                if (haystack % 2 == needle)
                {
                    result[i]++;
                }
                haystack >>= 1;
            }
        }
        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine(result[i]);
        }
    }
}
