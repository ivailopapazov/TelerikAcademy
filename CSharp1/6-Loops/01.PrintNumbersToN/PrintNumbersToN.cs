using System;

class PrintNumbersToN
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
                    Console.WriteLine(i);
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
