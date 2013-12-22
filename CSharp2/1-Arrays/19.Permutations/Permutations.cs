using System;
using System.Collections.Generic;
using System.Linq;

class Permutations
{
    static void Main()
    {
        // User input
        Console.Write("Please enter the N: ");
        int N = int.Parse(Console.ReadLine());

        int[] permutations = new int[N];

        for (int i = 0; i < N; i++)
        {
            permutations[i] = i + 1;
        }

        PrintPermutations(permutations, 1);
    }
    static void PrintPermutations(int[] elements, int position)
    {
        if (position >= elements.Length)
        {
            Console.WriteLine("{{{0}}}", string.Join(", ", elements));
        }
        else
        {
            PrintPermutations(elements, position + 1);
            for (int i = position; i < elements.Length; i++)
            {
                int temp = elements[i];
                elements[i] = elements[position - 1];
                elements[position - 1] = temp;

                PrintPermutations(elements, position + 1);

                elements[position - 1] = elements[i];
                elements[i] = temp;
            }
        }
    }
}
