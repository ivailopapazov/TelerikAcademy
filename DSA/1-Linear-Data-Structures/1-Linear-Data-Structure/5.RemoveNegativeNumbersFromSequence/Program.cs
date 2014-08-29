using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.RemoveNegativeNumbersFromSequence
{
    // 5.Write a program that removes from given sequence all negative numbers.
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = new List<int>();
            string entry = Console.ReadLine();
            while (entry != string.Empty)
            {
                sequence.Add(int.Parse(entry));
                entry = Console.ReadLine();
            }


            for (int i = sequence.Count - 1; i > 0; i--)
            {
                if (sequence[i] < 0)
                {
                    sequence.RemoveAt(i);
                }
            }

            Console.WriteLine(string.Join(", ", sequence));
        }
    }
}
