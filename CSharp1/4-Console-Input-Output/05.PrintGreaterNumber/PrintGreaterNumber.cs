using System;

class PrintGreaterNumber
{
    static void Main()
    {
        Console.Write("Please eneter first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Please eneter second number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        double greaterNumber = firstNumber > secondNumber ? firstNumber : secondNumber;
        Console.WriteLine("{0} is greater", greaterNumber);

    }
}
