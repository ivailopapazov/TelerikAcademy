using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class ZerosOfFactorial
{
    static void Main()
    {
        int N = 0;
        int trailingZeros = 0;
        BigInteger factorial = 1;

        // User input
        Console.Write("Please enter positive number N: ");
        if (!int.TryParse(Console.ReadLine(), out N) || N < 0)
        {
            Console.WriteLine("Invalid Input!");
            return;
        }

        // Calculating factorial
        for (int i = 1; i <= N; i++)
        {
            factorial *= i;
        }

        // Counting trailing zeros
        while (factorial % 10 == 0)
        {
            factorial /= 10;
            trailingZeros++;
        }

        // Print
        Console.WriteLine("The answer is {0} trailing zeros.", trailingZeros);

        // Quick way
        Console.WriteLine("Quick way: {0} / 5 = {1}. {0}! has {1} trailing zeros.", N, N / 5);
    }
}
