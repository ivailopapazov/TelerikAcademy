using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.CountingOccurances
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

            foreach (KeyValuePair<int, int> item in occurances)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
