using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.StrangeLandNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, uint> digits = new Dictionary<string, uint>() 
            {
                { "f"      , 0 },
                { "bIN"    , 1 },
                { "oBJEC"  , 2 },
                { "mNTRAVL", 3 },
                { "lPVKNQ" , 4 },
                { "pNWE"   , 5 },
                { "hT"     , 6 }
            };

            string num = "";
            List<uint> number = new List<uint>();

            for (int i = 0; i < input.Length; i++)
            {
                num += input[i];
                if (digits.ContainsKey(num))
                {
                    number.Add(digits[num]);
                    num = "";
                }
            }

            number.Reverse();
            ulong sum = 0;
            for (int i = 0; i < number.Count; i++)
            {
                sum += number[i] * Pow(i);
            }

            Console.WriteLine(sum);
        }
        static ulong Pow(int pos)
        {
            ulong result = 1;
            for (int i = 0; i < pos; i++)
            {
                result *= 7;
            }
            return result;
        }

    }
}
