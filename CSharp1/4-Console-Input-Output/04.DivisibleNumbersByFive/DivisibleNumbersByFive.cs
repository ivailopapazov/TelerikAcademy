using System;

class DivisibleNumbersByFive
{
    static void Main()
    {
        Console.Write("Please eneter first positive number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Please eneter second positive number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        int counter = 0;

        if (firstNumber > secondNumber)
        {
            firstNumber += secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber -= secondNumber;
        }

        for (int i = firstNumber; i <= secondNumber; i++)
        {
            if (i % 5 == 0)
            {
                counter++;
            }
        }
        Console.WriteLine("You have {0} divisible numbers by 5 in range {1} and {2}", counter, firstNumber, secondNumber);
    }
}
