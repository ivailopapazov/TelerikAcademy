using System;

class OddOrEvenInteger
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());
        bool isEven = (number % 2) == 0;
        Console.WriteLine("The number {0} is {1} number.", number, isEven ? "Even" : "Odd");
    }
}
