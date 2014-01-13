using System;

class CompareRealNumbers
{
    static void Main()
    {
        Console.Write("Enter first number:");
        decimal firstNum = Decimal.Parse(Console.ReadLine());
        Console.Write("Enter second number:");
        decimal secondNum = Decimal.Parse(Console.ReadLine());
        decimal precision = 1E-6M; // 0.000001

        bool isEqual = Math.Abs(firstNum - secondNum) < precision;
        Console.WriteLine("{0}. {1} precision used.", isEqual ? "Numbers are equal" : "Numbers are not equal", precision);
    }
}
