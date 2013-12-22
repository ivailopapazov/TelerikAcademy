using System;
using System.Collections.Generic;

class FindLongestIncreasingSequence
{
    static void Main()
    {
        // User input
        Console.Write("Please enter the array size: ");
        int arrayLength = int.Parse(Console.ReadLine());
        int[] numbers = new int[arrayLength];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Please enter number {0}: ", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // Variable Declaration
        int[] sequenceLength = new int[arrayLength];
        int[] previousMember = new int[arrayLength];
        previousMember[0] = int.MinValue;
        int maxLength = 0;
        int traceIndex = 0;
        List<int> result = new List<int>();

        // Solution

        for (int i = 1; i < numbers.Length; i++)
        {
            for (int j = i - 1; j >= 0; j--)
            {
                if (numbers[j] < numbers[i] && sequenceLength[j] >= sequenceLength[i])
                {
                    sequenceLength[i] = sequenceLength[j] + 1;
                    previousMember[i] = j;
                    if (sequenceLength[i] > maxLength)
                    {
                        maxLength = sequenceLength[i];
                        traceIndex = i;
                    }
                }
            }
        }

        while (previousMember[traceIndex] != int.MinValue)
        {
            result.Add(numbers[traceIndex]);
            traceIndex = previousMember[traceIndex];
        }

        result.Reverse();
        Console.WriteLine(string.Join(", ", result));
    }
}
