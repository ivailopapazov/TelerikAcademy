using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// BG coder results will be present in every project in this solution. I'm sorry for the messy code and poor comments.
// http://bgcoder.com/Contests/Submissions/View/295415

namespace _10_1.Zerg___
{
    class Program
    {
        static ulong Pow(int pos)
        {
            ulong result = 1;
            for (int i = 0; i < pos; i++)
            {
                result *= 15;
            }

            return result;
        }
        static void Main(string[] args)
        {
            // Input
            string dzverg = Console.ReadLine();

            // Variables
            ulong result = 0;
            Dictionary<string, uint> digits = new Dictionary<string, uint>() 
            {
                { "Rawr", 0 },
                { "Rrrr", 1 },
                { "Hsst", 2 },
                { "Ssst", 3 },
                { "Grrr", 4 },
                { "Rarr", 5 },
                { "Mrrr", 6 },
                { "Psst", 7 },
                { "Uaah", 8 },
                { "Uaha", 9 },
                { "Zzzz", 10 },
                { "Bauu", 11 },
                { "Djav", 12 },
                { "Myau", 13 },
                { "Gruh", 14 }
            };

            // Loop
            for (int i = dzverg.Length - 4, j = 0; i >= 0; i-=4, j++)
            {
                result += digits[dzverg.Substring(i, 4)] * Pow(j);
            }

            // prijtn
            Console.WriteLine(result);
       }
    }
}
