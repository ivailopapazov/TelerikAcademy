using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class AstrologicalDigits
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        string input = Console.ReadLine();
        input = input.Replace(".", "");
        input = input.Replace("-", "");
        BigInteger number = BigInteger.Parse(input);
        BigInteger result = 0;

        while (true)
        {
            result += number % 10;
            number /= 10;
            if (number == 0)
            {
                if (result < 10)
                {
                    break;
                }
                number = result;
                result = 0;
            }
        }

        Console.WriteLine(result);
    }
}
