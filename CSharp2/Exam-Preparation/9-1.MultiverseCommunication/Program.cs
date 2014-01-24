using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://bgcoder.com/Contests/Submissions/View/289734

namespace _9_1.MultiverseCommunication
{
    class Program
    {
        static long Pow(int radix, int num)
        {
            long sum = 1;
            for (int i = 0; i < num; i++)
            {
                sum *= radix;
            }

            return sum;
        }
        static void Main(string[] args)
        {
            Dictionary<string, int> digits = new Dictionary<string, int>();
            digits.Add("CHU", 0);
            digits.Add("TEL", 1);
            digits.Add("OFT", 2);
            digits.Add("IVA", 3);
            digits.Add("EMY", 4);
            digits.Add("VNB", 5);
            digits.Add("POQ", 6);
            digits.Add("ERI", 7);
            digits.Add("CAD", 8);
            digits.Add("K-A", 9);
            digits.Add("IIA", 10);
            digits.Add("YLO", 11);
            digits.Add("PLA", 12);

            // input
            string number = Console.ReadLine();
            long sum = 0;
            int pos = 0;
            for (int i = number.Length - 3; i >= 0; i-=3)
            {
                int digit = digits[number.Substring(i,3)];
                sum += digit * Pow(13, pos++);
            }
            Console.WriteLine(sum);

        }
    }
}
