using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NotDivisibleBy21
{
    static void Main()
    {
        Console.Write("Please enter number: ");
        int number = 0;
        if (int.TryParse(Console.ReadLine(), out number))
        {
            if (number > 0 && number < 1000)
            {
                for (int i = 1; i <= number; i++)
                {
                    if (i % 21 != 0) // If number is not divisible by 3 and 7 at the same time
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("Not in range [1; 1000]");
            }
        }
        else
        {
            Console.WriteLine("Invalid Input!");
        }

    }
}
