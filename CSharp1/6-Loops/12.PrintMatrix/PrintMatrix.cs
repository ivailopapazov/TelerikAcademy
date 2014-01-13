using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrintMatrix
{
    static void Main()
    {
        int N = 0;
        Console.Write("Please enter positive number N < 20: ");
        if (!int.TryParse(Console.ReadLine(), out N) || N < 0 || N > 19)
        {
            Console.WriteLine("Invalid Input!");
            return;
        }

        // Rows
        for (int i = 0; i < N; i++)
        {
            // Columns
            for (int j = 1; j <= N; j++)
            {
                Console.Write("{0, 2} ", j + i);
            }
            Console.WriteLine();
        }
    }
}
