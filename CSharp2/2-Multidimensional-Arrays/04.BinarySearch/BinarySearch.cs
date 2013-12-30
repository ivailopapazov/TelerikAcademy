using System;

class BinarySearch
{
    static void Main()
    {
        // User Input
        Console.Write("Please enter array size: ");
        int size = int.Parse(Console.ReadLine());
        Console.Write("Please enter number K: ");
        int needle = int.Parse(Console.ReadLine());
        int[] haystack = new int[size];
        for (int i = 0; i < haystack.Length; i++)
        {
            Console.Write("Please enter number {0}: ", i + 1);
            haystack[i] = int.Parse(Console.ReadLine());
        }

        // Sorting array
        Array.Sort(haystack);

        // Binary search method
        int needleIndex = Array.BinarySearch(haystack, needle);

        // In case needle is not found
        if (needleIndex < 0)
        {
            needleIndex = ~needleIndex - 1;
        }

        // Printing result
        Console.WriteLine(haystack[needleIndex]);
    }
}
