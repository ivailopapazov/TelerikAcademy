using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.RemoveOddElementOccurances
{
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

            Dictionary<int, int> occurances = new Dictionary<int, int>();
            for (int i = 0; i < sequence.Count; i++)
            {
                if (!occurances.ContainsKey(sequence[i]))
                {
                    occurances[sequence[i]] = 0;
                }

                occurances[sequence[i]]++;
            }

            List<int> resultList = new List<int>();
            for (int i = 0; i < sequence.Count; i++)
            {
                if (occurances[sequence[i]] % 2 == 0)
                {
                    resultList.Add(sequence[i]);
                }
            }

            Console.WriteLine(string.Join(", ", resultList));
        }
    }
}
