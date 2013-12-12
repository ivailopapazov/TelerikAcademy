using System;

class InitializeArray
{
    static void Main()
    {
        // Allocating array
        int[] numbers = new int[20];

        // Initializing array
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i * 5;
        }

        // Print array
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
