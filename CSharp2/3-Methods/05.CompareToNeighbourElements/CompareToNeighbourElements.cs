using System;

namespace NeighbourComparisions
{
    public class CompareToNeighbourElements
    {
        public static bool CompareToNeighbours(int[] array, int index)
        {
            // Initial condition: element is bigger than it's neighbours
            bool isBigger = true;

            // If element is not the last and the right neighbour is bigger
            if (index < array.Length - 1 && array[index] < array[index + 1])
            {
                isBigger = false;
            }
            // If element is not first and the left neighbour is bigger
            if (index > 0 && array[index] < array[index - 1])
            {
                isBigger = false;
            }
            return isBigger;
        }
        static void Main()
        {
            // User Input
            Console.Write("Please enter array size: ");
            int arraySize = int.Parse(Console.ReadLine());
            Console.Write("Please enter a position in array: ");
            int position = int.Parse(Console.ReadLine());
            int[] numbers = new int[arraySize];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Please enter number {0}: ", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // Method Call
            bool elementIsBigger = CompareToNeighbours(numbers, position);

            // Print Result
            Console.WriteLine("Element is bigger than it's neighbours: {0}", elementIsBigger);
        }
    }
}