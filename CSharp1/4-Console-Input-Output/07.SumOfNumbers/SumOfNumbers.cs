using System;

class SumOfNumbers
{
    static void Main()
    {
        Console.Write("How many numbers would you like to add: ");
        int numberCount = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= numberCount; i++)
        {
            Console.Write("Please enter number {0}: ", i);
            sum += int.Parse(Console.ReadLine());
        }
        Console.WriteLine("The sum is equal to {0}", sum);

    }
}
