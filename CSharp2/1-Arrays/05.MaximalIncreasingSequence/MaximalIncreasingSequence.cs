using System;

class MaximalIncreasingSequence
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
        int currentElement = numbers[0];
        int currentCount = 1;
        int bestCount = 0;
        int bestElement = 0;


        for (int i = 1; i < numbers.Length; i++)
        {
            // Counting sequences
            if (numbers[i] != currentElement + 1) // Switch to new sequence
            {
                currentCount = 1;
                currentElement = numbers[i];
            }
            else // New element of current sequence
            {
                currentCount++;
                currentElement++;
            }
            // Recording best sequence
            if (currentCount > bestCount)
            {
                bestCount = currentCount;
                bestElement = currentElement - currentCount + 1; // Taking the start of the sequence
            }
        }
        // Printing result
        Console.WriteLine("The best increasing sequence starts with {0} and has {1} therms", bestElement, bestCount);
    }
}
