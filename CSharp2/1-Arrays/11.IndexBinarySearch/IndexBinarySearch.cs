using System;

class IndexBinarySearch
{
    static void Main()
    {
        // User input
        Console.Write("Please enter the array size: ");
        int arrayLength = int.Parse(Console.ReadLine());
        Console.Write("Please enter element to search for: ");
        int needle = int.Parse(Console.ReadLine());
        int[] haystack = new int[arrayLength];
        for (int i = 0; i < haystack.Length; i++)
        {
            Console.Write("Please enter number {0}: ", i + 1);
            haystack[i] = int.Parse(Console.ReadLine());
        }
        
        // Variable Declaration
        int middle = haystack.Length / 2;
        int middleIndex = middle;

        // Binary search 
        while (needle != haystack[middleIndex])
        {
            middle /= 2;
            if (needle > haystack[middleIndex])
            {
                middleIndex += middle;
            }
            else if (needle < haystack[middleIndex])
            {
                middleIndex -= middle;
            }
        }

        // Printing result
        Console.WriteLine("Index of element is {0} and the value is {1}", middleIndex, haystack[middleIndex]);
    }
}
