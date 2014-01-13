using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GreatestCommonDivisor
{
    static void Main()
    {
        int firstNumber = 0;
        int secondNumber = 0;

        int divident = 0;
        int divisor = 0;
        int remainder = 1;
        
        // User input
        Console.Write("Please enter first non-zero number: ");
        if (!int.TryParse(Console.ReadLine(), out firstNumber) || firstNumber == 0)
        {
            Console.WriteLine("Invalid Input!");
            return;
        }
        Console.Write("Please enter second non-zero number: ");
        if (!int.TryParse(Console.ReadLine(), out secondNumber) || secondNumber == 0)
        {
            Console.WriteLine("Invalid Input!");
            return;
        }

        // Get absolute values
        divident = Math.Abs(firstNumber);
        divisor = Math.Abs(secondNumber);

        // Swap values if divisor is bigger number
        if (divident < divisor)
        {
            divident += divisor;
            divisor = divident - divisor;
            divident -= divisor;
        }

        // Euclidean method for GCD
        while (true)
        {
            remainder = divident % divisor;
            if (remainder != 0)
            {
                divident = divisor;
                divisor = remainder;
            }
            else
            {
                Console.WriteLine("gtc{{{0}, {1}}} = {2}", firstNumber, secondNumber, divisor);
                break;
            }
        }
    }
}
