using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class Tribonacci
{
    static void Main()
    {
        BigInteger firstTherm = BigInteger.Parse(Console.ReadLine());
        BigInteger secondTherm = BigInteger.Parse(Console.ReadLine());
        BigInteger thirdTherm = BigInteger.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        BigInteger nextTherm = 0;

        switch (n)
        {
            case 1:
                nextTherm = firstTherm;
                break;
            case 2:
                nextTherm = secondTherm;
                break;
            case 3:
                nextTherm = thirdTherm;
                break;
            default:
                for (BigInteger i = 3; i < n; i++)
                {
                    nextTherm = firstTherm + secondTherm + thirdTherm;
                    firstTherm = secondTherm;
                    secondTherm = thirdTherm;
                    thirdTherm = nextTherm;
                }
                break;
        }
        Console.WriteLine(nextTherm);
    }
}
