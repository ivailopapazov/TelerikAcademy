using System;
using System.Collections.Generic;

namespace _8_1._9GagNumbers
{
    class Program
    {
        static ulong Pow(int num, int pow)
        {
            ulong sum = 1;

            for (int i = 0; i < pow; i++)
            {
                sum *= (uint)num;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Dictionary<string, uint> digits = new Dictionary<string, uint>();
            digits.Add("-!", 0);
            digits.Add("**", 1);
            digits.Add("!!!", 2);
            digits.Add("&&", 3);
            digits.Add("&-", 4);
            digits.Add("!-", 5);
            digits.Add("*!!!", 6);
            digits.Add("&*!", 7);
            digits.Add("!!**!-", 8);

            //input
            string input = Console.ReadLine();
            string currentDigit = "";
            ulong sum = 0;
            List<ulong> converted = new List<ulong>();

            for (int i = 0; i < input.Length; i++)
            {
                currentDigit += input[i];

                if (digits.ContainsKey(currentDigit))
                {
                    converted.Add(digits[currentDigit]);
                    currentDigit = string.Empty;
                }
            }

            converted.Reverse();

            for (int i = 0; i < converted.Count; i++)
            {
                sum += converted[i] * Pow(9, i);
            }
            Console.WriteLine(sum);
        }
    }
}
