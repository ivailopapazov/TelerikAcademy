using System;

class SortThreeRealNumbers
{
    static void Main()
    {
        Console.Write("Please enter the first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Please enter the third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());

        if (firstNumber >= secondNumber)
        {
            if (firstNumber >= thirdNumber)
            {
                Console.WriteLine(firstNumber);
                if (secondNumber >= thirdNumber)
                {
                    Console.WriteLine(secondNumber);
                    Console.WriteLine(thirdNumber);
                }
                else
                {
                    Console.WriteLine(thirdNumber);
                    Console.WriteLine(secondNumber);
                }
            }
            else
            {
                Console.WriteLine(thirdNumber);
                Console.WriteLine(firstNumber);
                Console.WriteLine(secondNumber);
            }
        }
        else if (secondNumber >= thirdNumber)
        {
            Console.WriteLine(secondNumber);
            if (firstNumber >= thirdNumber)
            {
                Console.WriteLine(firstNumber);
                Console.WriteLine(thirdNumber);
            }
            else
            {
                Console.WriteLine(thirdNumber);
                Console.WriteLine(firstNumber);
            }
        }
        else
        {
            Console.WriteLine(thirdNumber);
            Console.WriteLine(secondNumber);
            Console.WriteLine(firstNumber);
        }
    }
}
