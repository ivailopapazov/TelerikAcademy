using System;

class QuickSortAlgorithm
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

        // Sorting 
        QuickSort(ref numbers, 0, numbers.Length - 1);

    }

    static void QuickSort(ref int[] elements, int leftBorder, int rightBorder)
    {
        // Bottom of recursion
        if (rightBorder - leftBorder < 1)
        {
            return;
        }

        // Variable Declaration
        int pivot = elements[leftBorder]; // Take the value of the first element for pivot 
        int min = leftBorder + 1;
        int max = rightBorder;
        int tmp = 0;

        // Swaping elements by comparing to pivot
        while (true)
        {
            // Searching for element greater than or equal to pivot from left to right
            while (min <= max && elements[min] < pivot) 
            {
                min++;
            }
            // Searching for element less than pivot from right to left
            while (max > min  && elements[max] >= pivot) 
            {
                max--;
            }

            // Swap elements
            if (min < max)
            {
                tmp = elements[min];
                elements[min] = elements[max];
                elements[max] = tmp;
                min++;
                max--;
            }
            // Swap pivot element with element left from min
            else
            {
                tmp = elements[leftBorder];
                elements[leftBorder] = elements[min - 1];
                elements[min - 1] = tmp;
                break;
            }
        }

        // Recursive method call
        QuickSort(ref elements, leftBorder, min - 1); // Recursion on left subarray
        QuickSort(ref elements, min, rightBorder); // Recursion on right subarray
    }
}
