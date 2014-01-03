using System;
using NeighbourComparisions;

class FindFirstBiggerNeighbour
{
    static void Main()
    {
        // User Input
        Console.Write("Please enter array size: ");
        int arraySize = int.Parse(Console.ReadLine());
        int[] numbers = new int[arraySize];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Please enter number {0}: ", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // Variable Declaration
        int resultIndex = -1;
        
        // Method Call for each element in array
        for (int i = 0; i < numbers.Length; i++)
        {
            if (CompareToNeighbourElements.CompareToNeighbours(numbers, i))
            {
                resultIndex = i;
                break;
            }
        }

        // Print Result
        Console.WriteLine("The first element in array that is bigger than it's neighbours has index of {0}", resultIndex);
    }
}
