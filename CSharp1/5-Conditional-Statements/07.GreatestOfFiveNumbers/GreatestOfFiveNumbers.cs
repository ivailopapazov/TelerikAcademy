using System;

class GreatestOfFiveNumbers
{
    static void Main()
    {
        int number = 0;
        int biggestNumber = 0; // container for the biggest number

        // Five number inputs from user
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Please enter number {0}: ", i + 1);
            number = int.Parse(Console.ReadLine());
            // If current number is bigger 
            if (number > biggestNumber)
            {
                biggestNumber = number; // overrides value 
            }
        }
        Console.WriteLine("The biggest number is {0}", biggestNumber);
    }
}
