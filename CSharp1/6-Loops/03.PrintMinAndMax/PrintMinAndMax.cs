using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrintMinAndMax
{
    static void Main()
    {
        Console.Write("Please enter value for N: ");

        int number = 0;
        int currentValue = 0;
        int minValue = int.MaxValue;
        int maxValue = int.MinValue;
        bool isNumber = false;

        if (int.TryParse(Console.ReadLine(), out number))
        {
            if (number < 2)
            {
                Console.WriteLine("N must be greater or equal than 2");
                return;
            }
            for (int i = 0; i < number; i++)
            {
                Console.Write("Please enter number {0}: ", i + 1);
                isNumber = int.TryParse(Console.ReadLine(), out currentValue);
                if (isNumber)
                {
                    if (currentValue > maxValue)
                    {
                        maxValue = currentValue;
                    }
                    if (currentValue < minValue)
                    {
                        minValue = currentValue;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input!");
                    i--; // Repeat iteration
                }
            }
            Console.WriteLine("Minimal value is {0} and maximal value is {1}", minValue, maxValue);
        }
        else
        {
            Console.WriteLine("Invalid Input!");
        }
    }
}
