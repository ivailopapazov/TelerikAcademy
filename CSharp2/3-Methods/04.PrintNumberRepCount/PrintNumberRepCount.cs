using System;

class PrintNumberRepCount
{
    static int NumberRepCount(int[] haystack, int needle)
    {
        // Declare Counter
        int repCount = 0;

        // Iterate Array
        for (int i = 0; i < haystack.Length; i++)
        {
            // Count every occurance of the needle
            if (haystack[i] == needle)
            {
                repCount++;
            }
        }

        // Return Needle
        return repCount;
    }
    static void Main()
    {
        // User Input
        Console.Write("Please enter array size: ");
        int arraySize = int.Parse(Console.ReadLine());
        Console.Write("Please enter a number to search for: ");
        int numberForCount = int.Parse(Console.ReadLine());
        int[] numbers = new int[arraySize];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Please enter number {0}: ", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // Method Call
        int count = NumberRepCount(numbers, numberForCount);

        // Print Result
        Console.WriteLine("Number {0} appears {1} times.", numberForCount, count);
    }
}
