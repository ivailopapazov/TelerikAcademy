using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class MathExpression
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double N = double.Parse(Console.ReadLine());
        double M = double.Parse(Console.ReadLine()); // non-zero
        double P = double.Parse(Console.ReadLine()); // non-zero

        double numerator = (N * N) + (1 / (M * P)) + 1337;
        double denominator = N - (128.523123123 * P);
        double rad = (int)M % 180;
        double result = numerator / denominator + Math.Sin(rad);

        Console.WriteLine("{0:F6}", result);
    }
}
