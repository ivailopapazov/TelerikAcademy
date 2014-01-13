using System;

class CheckForPrimeNumber
{
    static void Main()
    {
        Console.Write("Please enter positive number:");
        int number = int.Parse(Console.ReadLine());
        double numberSqrt = Math.Sqrt(number);
        bool isPrime = true;
        for (int i = 2; i <= numberSqrt; i++)
        {
            if ((number % i) == 0)
            {
                isPrime = false;
                break;
            }
        }
        Console.WriteLine("The number {0} {1} prime number.", number, isPrime ? "is" : "is not");
    }
}
