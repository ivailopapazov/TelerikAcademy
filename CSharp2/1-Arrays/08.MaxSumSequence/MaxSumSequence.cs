using System;
using System.Collections.Generic;

class MaxSumSequence
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
        int maxSum = 0;
        int maxSeqSum = 0;
        int seqStart = 0;
        int maxSeqStart = 0;
        bool negativeNumberSet = true;
        List<int> subSet = new List<int>();

        // Solution
        for (int i = 0; i < numbers.Length; i++)
        {
            // Positive sequence sum
            if (maxSeqSum + numbers[i] > 0)
            {
                maxSeqSum += numbers[i];
                negativeNumberSet = false;
            }
            // Break of sequence (negative sum)
            else
            {
                maxSeqSum = 0; // Starting new sequence sum
                seqStart = i + 1; // Remember position of next positive number (start of new sequence)
            }

            // Max sum
            if (maxSum < maxSeqSum)
            {
                maxSum = maxSeqSum; // Store max sum value
                maxSeqStart = seqStart; // Remember start position of current max sequence 
            }
        }

        // Case when all numbers are negative
        if (negativeNumberSet)
        {
            Array.Sort(numbers);
            maxSum = numbers[numbers.Length - 1];
            subSet.Add(numbers[numbers.Length - 1]);
        }
        // If there are positive numbers
        else
        {
            for (int i = maxSeqStart, sum = 0; sum != maxSum; i++)
            {
                sum += numbers[i];
                subSet.Add(numbers[i]);
            }
        }

        // Printing result
        Console.WriteLine("The sequence of maximal sum is {{ {0} }} and its sum is {1}", string.Join(", " ,subSet), maxSum);
    }
}
