using System;

class MergeSortAlgorithm
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

        // Sorting array
        int[] sortedNumbers = MergeSort(numbers);
        
        // Printing result
        Console.WriteLine("Unsorted array: {{ {0} }}", string.Join(", ", numbers));
        Console.WriteLine("Sorted array: {{ {0} }}", string.Join(", ", sortedNumbers));
    }

    static int[] MergeSort(int[] elements)
    {
        // Return when single element is left
        if (elements.Length == 1)
        {
            return elements;
        }

        // Variable Declaration for splited arrays
        int median = elements.Length / 2;
        int[] leftElements = new int[median];
        int[] rightElements = new int[elements.Length - median];

        // Spliting elements into left and right arrays;
        for (int i = 0; i < leftElements.Length; i++) // for left array
        {
            leftElements[i] = elements[i];
        }
        for (int i = 0; i < rightElements.Length; i++) // for right array
        {
            rightElements[i] = elements[i + median];
        }

        // Recursive method call
        int[] leftSorted = MergeSort(leftElements);
        int[] rightSorted = MergeSort(rightElements);

        // Variable declaration for sorted arrays
        int[] sortedElements = new int[elements.Length];
        int minLeft = 0;
        int minRight = 0;

        // Compare sorted arrays
        for (int i = 0; i < sortedElements.Length; i++)
        {
            // If left index is out of range
            if (minLeft >= leftSorted.Length) 
            {
                sortedElements[i] = rightSorted[minRight];
                minRight++;
            }
            // If right index is out of range
            else if (minRight >= rightSorted.Length) 
            {
                sortedElements[i] = leftSorted[minLeft];
                minLeft++;
            }
            // If min right array value is smaller or equal than min left value
            else if (rightSorted[minRight] <= leftSorted[minLeft])
            {
                sortedElements[i] = rightSorted[minRight];
                minRight++;
            }
            else // if (rightSorted[minRight] > leftSorted[minLeft])
            {
                sortedElements[i] = leftSorted[minLeft];
                minLeft++;
            }
        }

        // Returning sorted array
        return sortedElements;
    }
}
