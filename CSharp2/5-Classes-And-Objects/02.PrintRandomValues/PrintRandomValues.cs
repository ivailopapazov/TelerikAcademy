using System;

class PrintRandomValues
{
    static void Main()
    {
        // Create instance of class random
        Random randomNumber = new Random();

        // Print 10 random numbers
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(randomNumber.Next(100, 201));
        }
    }
}
