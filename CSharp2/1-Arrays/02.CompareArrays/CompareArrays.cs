using System;

class CompareArrays
{
    static void Main()
    {
        bool identicalArrays = true;
        // User input for first array
        Console.Write("Please enter first array size: ");
        int arrayLength = int.Parse(Console.ReadLine());
        int[] firstArray = new int[arrayLength];
        for (int i = 0; i < firstArray.Length; i++)
        {
            Console.Write("Please enter number {0}: ", i + 1);
            firstArray[i] = int.Parse(Console.ReadLine());
        }

        // User input for second array
        Console.Write("Please enter second array size: ");
        arrayLength = int.Parse(Console.ReadLine());
        int[] secondArray = new int[arrayLength];
        for (int i = 0; i < secondArray.Length; i++)
        {
            Console.Write("Please enter number {0}: ", i + 1);
            secondArray[i] = int.Parse(Console.ReadLine());
        }

        // Compare array lengths
        if (firstArray.Length != secondArray.Length)
        {
            Console.WriteLine("Array lengths missmatch");
            identicalArrays = false;
        }
        // Compare array elements
        else
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    Console.WriteLine("Array elemens missmatch");
                    identicalArrays = false;
                    break;
                }
            }
        }

        // Printing result
        Console.Write("The arrays {{ {0} }} AND {{ {1} }} ", string.Join(", ", firstArray), string.Join(", ", secondArray));
        if (identicalArrays) 
        {
            Console.WriteLine("are identical");
        }
        else 
        {
            Console.WriteLine("are not identical");
        }
    }
}
