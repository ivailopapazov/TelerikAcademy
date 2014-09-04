using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ValueOccurrencesCounter
{
    class ValueOccurrencesCounter
    {
        static void Main()
        {
            double[] inputArray = new double[] { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };
            Dictionary<double, int> countedOccurrences = OccurrencesCounter(inputArray);
            OccurrencesPrinter(countedOccurrences);
        }

        static Dictionary<double, int> OccurrencesCounter(double[] input)
        {
            Dictionary<double, int> occurrences = new Dictionary<double, int>();
            foreach (double element in input)
            {
                if (!occurrences.ContainsKey(element))
                {
                    occurrences[element] = 0;
                }

                occurrences[element]++;
            }

            return occurrences;
        }

        static void OccurrencesPrinter(Dictionary<double, int> occurrences)
        {
            foreach (KeyValuePair<double, int> item in occurrences)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
