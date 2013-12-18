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

        // Solution 1: Works only for positive numbers but it's faster
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

        //// Solution 2: Slower, but works with negative numebrs
        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    for (int j = i; j < numbers.Length; j++)
        //    {
        //        sum += numbers[j];
        //        seqElements.Add(numbers[j]);

        //        if (sum == S)
        //        {
        //            sequenceExists = true;
        //            break;
        //        }
        //    }
        //    if (sequenceExists)
        //    {
        //        break;
        //    }
        //    sum = 0;
        //    seqElements.Clear();
        //}

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
