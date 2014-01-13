using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NthCatalanNumber
{
    static void Main()
    {
        int N = 0;
        double catalanNumber = 1;
        double numerator = 1;
        double denumerator = 1;

        // User input
        Console.Write("Please enter positive number N: ");
        if (!int.TryParse(Console.ReadLine(), out N) || N < 0)
        {
            Console.WriteLine("Invalid Input!");
            return;
        }
        for (int i = 1; i <= 2 * N; i++)
        {
            numerator *= i;
        }
        denumerator = N + 1;
        for (int i = 1; i <= N; i++)
        {
            denumerator *= i * i;
        }
        catalanNumber = numerator / denumerator;
        Console.WriteLine(catalanNumber);
    }
}
