using System;

class PrintStringSum
{
    static void Main()
    {
        // User input
        Console.Write("Please enter a string of numbers separated by space: ");
        string input = Console.ReadLine();

        // Create StringSum object
        StringSum numbers = new StringSum(input);

        // Calculate sum
        int sum = numbers.CalculateSum();

        // Print result
        Console.WriteLine(sum);
    }
}
