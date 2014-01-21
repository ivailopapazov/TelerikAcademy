using System;
using System.Collections.Generic;

class Program
{
    static long TraverseValley(int[] valley)
    {
        int[] pattern = ParseNumber(Console.ReadLine());
        bool[] visitetSteps = new bool[valley.Length];
        visitetSteps[0] = true;
        int step = 0;
        long sum = valley[step];

        while (true)
        {
            for (int i = 0; i < pattern.Length; i++)
            {
                step += pattern[i];
                if (step >= 0 && step < valley.Length && !visitetSteps[step])
                {
                    sum += valley[step];
                    visitetSteps[step] = true;
                }
                else
                {
                    return sum;
                }
            }
        }
    }
    static int[] ParseNumber(string text)
    {
        string[] stringNumbers = text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        int[] arr = Array.ConvertAll(stringNumbers, int.Parse);

        return arr;
    }
    static void Main()
    {
        // Parse valley
        int[] valley = ParseNumber(Console.ReadLine());

        // Declarations
        long bestSum = int.MinValue;

        // parse patterns
        int size = int.Parse(Console.ReadLine());
        for (int i = 0; i < size; i++)
        {
            long sum = TraverseValley(valley);
            if (sum > bestSum)
            {
                bestSum = sum;
            }
        }

        // Pirnt
        Console.WriteLine(bestSum);
    }
}
