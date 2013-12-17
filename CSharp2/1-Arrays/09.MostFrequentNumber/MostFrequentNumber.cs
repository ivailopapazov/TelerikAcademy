using System;

class MostFrequentNumber
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
        int currentNumber = 0;
        int currentCount = 0;
        int bestNumber = 0;
        int bestCount = 0;

        // Counting repeating numbers
        for (int i = 0; i < numbers.Length; i++)
        {
            // Reset current values
            currentNumber = numbers[i];
            currentCount = 0;

            // Counting
            for (int j = i; j < numbers.Length; j++)
            {
                if (currentNumber == numbers[j])
                {
                    currentCount++;
                }
            }

            // Storing
            if (currentCount > bestCount)
            {
                bestCount = currentCount;
                bestNumber = currentNumber;
            }
        }

        // Printing result
        Console.WriteLine("Most frequent number is {0} and it shows {1} times", bestNumber, bestCount);
    }
}
