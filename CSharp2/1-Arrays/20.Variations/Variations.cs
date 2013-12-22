using System;
using System.Collections.Generic;
using System.Linq;

class Variations
{
    static void Main()
    {
        // User input
        Console.Write("Please enter the N: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Please enter the K: ");
        int K = int.Parse(Console.ReadLine());

        int[] variations = new int[K];
        PrintVariations(variations, 0, N);
    }

    static void PrintVariations(int[] elements, int position, int endNumber)
    {
        if (position >= elements.Length)
        {
            Console.WriteLine("{{{0}}}", string.Join(", ", elements));
        }
        else
        {
            for (int i = 1; i <= endNumber; i++)
            {
                elements[position] = i;
                PrintVariations(elements, position + 1, endNumber);
            }
        }
    }
}
