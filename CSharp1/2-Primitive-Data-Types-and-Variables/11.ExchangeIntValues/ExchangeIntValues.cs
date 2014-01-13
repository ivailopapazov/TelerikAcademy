using System;

class ExchangeIntValues
{
    static void Main()
    {
        int firstNumber = 5;
        int secondNumber = 10;
        Console.WriteLine("Initial numbers are: firstNumber = {0} and secondNumber = {1}", firstNumber, secondNumber);
        firstNumber += secondNumber;
        secondNumber = firstNumber - secondNumber;
        firstNumber -= secondNumber;
        Console.WriteLine("Magic happens and numbers are: firstNumber = {0} and secondNumber = {1}", firstNumber, secondNumber);
    }
}