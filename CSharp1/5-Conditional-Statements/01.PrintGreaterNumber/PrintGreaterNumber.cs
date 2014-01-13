using System;

class PrintGreaterNumber
{
    static void Main()
    {
        Console.Write("Please enter the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        // Exchange values if firstNumber is smaller
        if (firstNumber < secondNumber)
        {
            firstNumber += secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber -= secondNumber;
        }
        Console.WriteLine("{0} is the bigger number.", firstNumber);
    }
}
