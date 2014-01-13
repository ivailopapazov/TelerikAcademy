using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TribonacciTriangle
{
    static void Main()
    {
        long firstTherm = long.Parse(Console.ReadLine());
        long secondTherm = long.Parse(Console.ReadLine());
        long thirdTherm = long.Parse(Console.ReadLine());
        int lines = int.Parse(Console.ReadLine());
        int therms = (lines * (lines + 1)) / 2;

        long[] tribonacci = new long[therms];

        tribonacci[0] = firstTherm;
        tribonacci[1] = secondTherm;
        tribonacci[2] = thirdTherm;

        for (int i = 3; i < therms; i++)
        {
            tribonacci[i] = firstTherm + secondTherm + thirdTherm;
            firstTherm = secondTherm;
            secondTherm = thirdTherm;
            thirdTherm = tribonacci[i];
        }
    }
}


