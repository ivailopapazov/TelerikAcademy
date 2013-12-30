using System;

class SortStringArray
{
    static void Main()
    {
        // User Input
        Console.Write("Please enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());
        string[] words = new string[size];
        for (int i = 0; i < words.Length; i++)
        {
            Console.Write("Please enter word {0}: ", i + 1);
            words[i] = Console.ReadLine();
        }

        // Variable Declaration
        QuickSort(words);
        Console.WriteLine(new string('-', 20));
        foreach (var word in words)
        {
            Console.WriteLine(word);
        }

        // Some solution
    }
    static void QuickSort(string[] stringArray, int leftBorder, int rightBorder)
    {
        if (rightBorder - leftBorder < 1)
        {
            return;
        }

        int pivot = stringArray[leftBorder].Length;
        int leftIndex = leftBorder + 1;
        int rightIndex = rightBorder;
        string tmp = string.Empty;

        while (true)
        {
            while (leftIndex <= rightIndex && stringArray[leftIndex].Length < pivot)
            {
                leftIndex++;
            }
            while (rightIndex > leftIndex && stringArray[rightIndex].Length > pivot)
            {
                rightIndex--;
            }

            if (leftIndex < rightIndex)
            {
                tmp = stringArray[leftIndex];
                stringArray[leftIndex] = stringArray[rightIndex];
                stringArray[rightIndex] = tmp;
                leftIndex++;
                rightIndex--;
            }
            else
            {
                tmp = stringArray[leftBorder];
                stringArray[leftBorder] = stringArray[leftIndex - 1];
                stringArray[leftIndex - 1] = tmp;
                break;
            }
        }

        QuickSort(stringArray, leftBorder, leftIndex - 1);
        QuickSort(stringArray, leftIndex, rightBorder);
    }

    static void QuickSort(string[] stringArray)
    {
        QuickSort(stringArray, 0, stringArray.Length - 1);
    }
}
