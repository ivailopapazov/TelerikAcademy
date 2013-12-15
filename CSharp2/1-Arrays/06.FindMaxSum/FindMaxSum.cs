using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FindMaxSum
{
    static void Main()
    {
        // Variable Declaration
        int maxSum = 0;

        // User input
        Console.Write("Please enter the array size: ");
        int arrayLength = int.Parse(Console.ReadLine());
        Console.Write("Please enter the number for K: ");
        int k = int.Parse(Console.ReadLine());
        if (k < 1 || k > arrayLength)
        {
            Console.WriteLine("Invalid value!");
            return;
        }
        int[] numbers = new int[arrayLength];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Please enter number {0}: ", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // Sort array
        Array.Sort(numbers);

        // Get the sum of the last K elements
        for (int i = numbers.Length - 1; i > numbers.Length - k - 1; i--)
        {
            maxSum += numbers[i];
        }

        // Printing result
        Console.WriteLine("Maximal sum of {0} elements is equal to {1}", k, maxSum);
    }
}
