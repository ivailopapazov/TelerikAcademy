namespace _3.Divisors
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Divisors
    {
        private static int minDivisors = int.MaxValue;
        private static int minNumber = int.MaxValue;

        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            char[] digits = new char[count];

            for (int i = 0; i < digits.Length; i++)
            {
                digits[i] = char.Parse(Console.ReadLine()); 
            }

            Array.Sort(digits);
            PermuteDigits(digits, 0, digits.Length);

            Console.WriteLine(minNumber);
        }

        static void PermuteDigits(char[] arr, int start, int n)
        {
            int currentNumber = int.Parse(new string(arr));
            FindDivisors(currentNumber);

            for (int left = n - 2; left >= start; left--)
            {
                for (int right = left + 1; right < n; right++)
                {
                    if (arr[left] != arr[right])
                    {
                        SwapDigits(ref arr[left], ref arr[right]);
                        PermuteDigits(arr, left + 1, n);
                    }
                }

                var firstElement = arr[left];
                for (int i = left; i < n - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }

                arr[n - 1] = firstElement;
            }
        }

        private static void SwapDigits(ref char firstValue, ref char secondValue)
        {
            var oldValue = firstValue;
            firstValue = secondValue;
            secondValue = oldValue;
        }

        private static void FindDivisors(int number)
        {
            var divisorsCount = 0;

            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    divisorsCount++;
                }
            }

            divisorsCount++;

            if (divisorsCount < minDivisors)
            {
                minDivisors = divisorsCount;
                minNumber = number;
            }
            else if (divisorsCount == minDivisors && minNumber > number)
            {
                minNumber = number;
            }
        }
    }
}
