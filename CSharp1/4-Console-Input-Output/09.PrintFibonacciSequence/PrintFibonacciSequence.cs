using System;

class PrintFibonacciSequence
{
    static void Main()
    {
        decimal firstThrem = 0;
        decimal secondTherm = 1;
        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine("{0,-3} - {1}", i, firstThrem);
            secondTherm += firstThrem;
            firstThrem = secondTherm - firstThrem;
        }
    }
}
