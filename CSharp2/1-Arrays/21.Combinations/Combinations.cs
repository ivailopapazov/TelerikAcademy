using System;
using System.Collections.Generic;
using System.Linq;

// Sujalqvam za lipsata na komentari v poslednite zadachi, no ne mi stigna vreme da gi donaglasq da sa po priqtni za chetene. Izvinqvam se.
class Combinations
{
    static void Main()
    {
        // User input
        Console.Write("Please enter the N: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Please enter the K: ");
        int K = int.Parse(Console.ReadLine());

        // Solution
        int[] combinations = new int[K];
        PrintCombinations(combinations, 0, 1, N);

    }
    static void PrintCombinations(int[] elements, int position, int startNumber, int endNumber)
    {
        if (position >= elements.Length)
        {
            Console.WriteLine("{{{0}}}", string.Join(", ", elements));
        }
        else
        {
            for (int i = startNumber; i <= endNumber; i++)
            {
                elements[position] = i;
                PrintCombinations(elements, position + 1, i + 1, endNumber);
            }
        }
    }
}
