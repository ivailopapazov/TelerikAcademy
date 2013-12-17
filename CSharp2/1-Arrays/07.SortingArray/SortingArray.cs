using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SortingArray
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

        // Selection sort algorithm
        for (int i = 0; i < numbers.Length - 1; i++)
        {

            int minIndex = i;
            int minValue = numbers[i];

            // Search for element with lower value
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[j] < minValue)
                {
                    minIndex = j;
                    minValue = numbers[j];
                }
            }

            // Swap elements
            numbers[minIndex] = numbers[i];
            numbers[i] = minValue;
        }

        // Printing result
        Console.WriteLine("Print sorted array:");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
