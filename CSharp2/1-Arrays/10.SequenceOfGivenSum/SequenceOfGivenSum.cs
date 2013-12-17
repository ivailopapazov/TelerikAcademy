using System;
using System.Collections.Generic;

class SequenceOfGivenSum
{
    static void Main()
    {
        // User input
        Console.Write("Please enter the array size: ");
        int arrayLength = int.Parse(Console.ReadLine());
        Console.Write("Please enter desired sequence sum: ");
        int S = int.Parse(Console.ReadLine());
        int[] numbers = new int[arrayLength];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Please enter number {0}: ", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // Variable Declaration
        int sum = 0;
        bool sequenceExists = false;
        List<int> seqElements = new List<int>();

        // Solution
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
            seqElements.Add(numbers[i]);

            while (sum > S)
            {
                sum -= seqElements[0];
                seqElements.RemoveAt(0);
            }
            if (sum == S)
            {
                sequenceExists = true;
                break;
            }
        }

        // Printing result
        if (sequenceExists)
        {
            Console.WriteLine("The sequence with sum of {0} is: {{ {1} }}", S, string.Join(", ", seqElements));
        }
        else
        {
            Console.WriteLine("There is no sequence with sum of {0}", S);
        }
    }
}
