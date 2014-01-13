using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SumOfSequence
{
    static void Main()
    {
        int numberN = 0;
        int numberX = 0;

        double sum = 1D;
        double factorial = 1D;
        double exponent = 1D;

        Console.Write("Please enter number for N: ");
        if (!int.TryParse(Console.ReadLine(), out numberN))
        {
            Console.WriteLine("Invalid Input!");
            return;
        }
        Console.Write("Please enter number for X: ");
        if (!int.TryParse(Console.ReadLine(), out numberX))
        {
            Console.WriteLine("Invalid Input!");
            return;
        }

        for (int i = 1; i <= numberN; i++)
        {
            factorial *= i;
            exponent *= numberX;
            sum += factorial / exponent;
        }
        Console.WriteLine(sum);
    }
}
