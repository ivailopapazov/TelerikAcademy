using System;
using System.Collections.Generic;

class FindMaximalSequence
{
    static void Main()
    {
        // Variable declaration
        int bestElement = 0;
        int currentElement = 0;
        int bestElementCount = 0;
        int currentElementCount = 0;

        // User input for array
        Console.Write("Please enter the array size: ");
        int arrayLength = int.Parse(Console.ReadLine());
        int[] numbers = new int[arrayLength];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Please enter number {0}: ", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());

            // Counting sequance of equal elements
            if (currentElement != numbers[i]) // element switch
            {
                currentElementCount = 1;
                currentElement = numbers[i];
            }
            else // element sequence
            {
                currentElementCount++;
            }

            // Record best sequence
            if (currentElementCount > bestElementCount)
            {
                bestElementCount = currentElementCount;
                bestElement = currentElement;
            }
        }
        // Printing result
        Console.WriteLine("Maximal sequence consists of element {0} and repeats {1} times", bestElement, bestElementCount);
    }
}
