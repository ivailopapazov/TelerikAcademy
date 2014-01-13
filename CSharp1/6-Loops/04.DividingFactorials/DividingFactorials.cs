using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class DividingFactorials
{
    static void Main()
    {
        int K = 0;
        int N = 0;
        BigInteger result = 1;

        Console.Write("Please enter number for N:N>2 ");
        if (!int.TryParse(Console.ReadLine(), out N))
        {
            Console.WriteLine("Invalid Input!");
            return;
        }
        Console.Write("Please enter number for K:1<K<N ");
        if (!int.TryParse(Console.ReadLine(), out K))
        {
            Console.WriteLine("Invalid Input!");
            return;
        }

        if (1 < K && K < N)
        {
            for (int i = N; i > K; i--)
            {
                result *= i;
            }
            Console.WriteLine("The result of {0}!/{1}! is equal to {2}", N, K, result);
        }
        else
        {
            Console.WriteLine("Invalid Values! 1 < K < N");
        }
    }
}
