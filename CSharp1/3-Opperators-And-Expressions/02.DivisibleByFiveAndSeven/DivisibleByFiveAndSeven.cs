using System;

class DivisibleByFiveAndSeven
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());
        bool isDivisible = ((number % 5) == 0) && ((number % 7) == 0);
        Console.WriteLine("The number {0} {1} divisible by 7 and 5", number, isDivisible ? "is" : "is not");
    }

}
