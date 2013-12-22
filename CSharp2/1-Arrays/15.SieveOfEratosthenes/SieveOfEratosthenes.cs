using System;
using System.Collections.Generic;

class SieveOfEratosthenes
{
    static void Main()
    {
        // User input
        Console.Write("Please enter number from 1 to 10 000 000: ");
        int N = int.Parse(Console.ReadLine());

        // Variable Declaration
        int primeCount = 0;
        bool[] isPrime = new bool[N + 1];

        // Fill boolean array with value of true
        for (int i = 2; i < isPrime.Length; i++)
        {
            isPrime[i] = true;
        }

        // Sieve of eratosthenes
        for (int i = 2; i <= Math.Sqrt(isPrime.Length); i++)
        {
            if (isPrime[i])
            {
                for (int j = i * 2; j < isPrime.Length; j += i)
                {
                    isPrime[j] = false;
                }
            }
        }

        // Counting prime numbers
        for (int i = 0; i < isPrime.Length; i++)
        {
            if (isPrime[i])
            {
                primeCount++;
                // Here you can print prime numbers if you want
            }
        }

        // Printing result
        Console.WriteLine("Prime numbers count: {0}", primeCount);
    }
}
