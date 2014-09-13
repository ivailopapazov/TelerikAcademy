namespace _4.ColorBalls
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        private static Dictionary<int, BigInteger> factorials = new Dictionary<int, BigInteger>();

        static void Main()
        {
            char[] balls = Console.ReadLine().ToCharArray();
            Dictionary<int, int> ballGroups = new Dictionary<int, int>();

            for (int i = 0; i < balls.Length; i++)
            {
                if (!ballGroups.ContainsKey(balls[i]))
                {
                    ballGroups[balls[i]] = 0;
                }

                ballGroups[balls[i]]++;
            }

            BigInteger result = CalculateFactorial(balls.Length);
            foreach (var ballGroup in ballGroups)
            {
                result /= CalculateFactorial(ballGroup.Value);
            }

            Console.WriteLine(result);
        }

        static BigInteger CalculateFactorial(int n)
        {
            if (factorials.ContainsKey(n))
            {
                return factorials[n];
            }

            BigInteger result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
                factorials.Add(i, result);
            }

            return result;
        }
    }
}
