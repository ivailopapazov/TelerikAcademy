using System;

class PrintThreeNumbers
{
    static void Main()
    {
        Console.Write("Please eneter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Please eneter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Please eneter third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());
        long sum = (long)firstNumber + secondNumber + thirdNumber;


        Console.WriteLine("Your numbers are: {0}, {1} and {2}", firstNumber, secondNumber, thirdNumber);
        Console.WriteLine("The sum of the numbers is equal to {0}", sum);
    }
}
