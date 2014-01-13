using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class SumOfFibonacciMembers
{
    static void Main()
    {
        int N = 0;

        BigInteger firstTerm = 0;
        BigInteger secondTerm = 1;
        BigInteger sum = 0;

        Console.Write("Please enter number for N: ");
        if (!int.TryParse(Console.ReadLine(), out N) || N < 1)
        {
            Console.WriteLine("Invalid Input!");
            return;
        }
        for (int i = 0; i < N; i++)
        {
            sum += firstTerm;
            secondTerm += firstTerm;
            firstTerm = secondTerm - firstTerm;
        }
        Console.WriteLine("The sum of the first {0} therms of the Fibonacci sequence is equal to:", N);
        Console.WriteLine(sum);
    }
}
