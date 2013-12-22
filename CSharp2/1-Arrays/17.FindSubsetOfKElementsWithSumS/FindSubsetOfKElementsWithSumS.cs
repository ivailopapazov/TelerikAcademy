using System;
using System.Collections.Generic;
using System.Linq;

class FindSubsetOfKElementsWithSumS
{
    static void Main()
    {
        // User input
        Console.Write("Please enter the N: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Please enter the K: ");
        int K = int.Parse(Console.ReadLine());
        Console.Write("Please enter the S: ");
        int S = int.Parse(Console.ReadLine());
        int[] numbers = new int[N];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Please enter number {0}: ", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // Variable declaration
        List<List<int>> subsets = new List<List<int>>();

        for (int i = 0; i < numbers.Length; i++)
        {
            int count = subsets.Count;
            for (int j = 0; j < count; j++)
            {
                List<int> currentSubset = new List<int>(subsets[j]);
                currentSubset.Add(numbers[i]);

                if (currentSubset.Sum() < S)
                {
                    subsets.Add(currentSubset);
                }
                else if (currentSubset.Sum() == S && currentSubset.Count == K)
                {
                    Console.WriteLine(string.Join(", ", currentSubset));
                    return;
                }
            }
            if (numbers[i] < S)
            {
                subsets.Add(new List<int>() { numbers[i] });
            }
            else if (numbers[i] == S && K == 1)
            {
                Console.WriteLine(numbers[i]);
                return;
            }
        }
    }
}
