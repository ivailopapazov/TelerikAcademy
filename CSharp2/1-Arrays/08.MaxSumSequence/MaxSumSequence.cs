using System;

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
        
        // Declaration
        int maxSum = 0;
        int maxSeqSum = 0;

        // Solution
        for (int i = 0; i < numbers.Length; i++)
        {
            // Sequence sum
            if (maxSeqSum + numbers[i] > 0)
            {
                maxSeqSum += numbers[i];
            }
            else if (numbers[i] > 0)
            {
                maxSeqSum = numbers[i];
            }
            else
            {
                maxSeqSum = 0;
            }

            // Max sum
            if (maxSum < maxSeqSum)
            {
                maxSum = maxSeqSum;
            }
        }
        Console.WriteLine(maxSum);
    }
}
