using System;
using System.Collections.Generic;

// http://bgcoder.com/Contests/Submissions/View/282989

class Program
{
    static void Main()
    {
        // input
        string[] input = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        int[] route = Array.ConvertAll(input, int.Parse);

        // Declare
        int bestLength = 1;

        for (int entry = 0; entry < route.Length; entry++)
        {
            for (int step = 1; step < route.Length; step++)
            {
                int currentNumber = route[entry];
                int length = 1;
                int jump = entry + step;
                if (jump >= route.Length)
                {
                    jump -= route.Length;
                }

                while (route[jump] > currentNumber)
                {
                    currentNumber = route[jump];
                    length++;
                    jump += step;
                    if (jump >= route.Length)
                    {
                        jump -= route.Length;
                    }
                }

                if (length > bestLength)
                {
                    bestLength = length;
                }
            }
        }

        // print
        Console.WriteLine(bestLength);
    }
}
