using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.OddNumberStringsExtractor
{
    class OddNumberStringsExtractor
    {
        static void Main(string[] args)
        {
            string[] input = new string[] {"C#", "SQL", "PHP", "PHP", "SQL", "SQL" };

            Dictionary<string, int> wordOccurrences = OccurrencesCounter(input);
            string[] extractedWords = OddWordsExtractor(wordOccurrences);

            Console.WriteLine(string.Join(", ", extractedWords));
        }

        static Dictionary<string, int> OccurrencesCounter(string[] inputArray)
        {
            Dictionary<string, int> occurrences = new Dictionary<string, int>();
            foreach (string word in inputArray)
            {
                if (!occurrences.ContainsKey(word))
                {
                    occurrences[word] = 0;
                }

                occurrences[word]++;
            }

            return occurrences;
        }

        static string[] OddWordsExtractor(Dictionary<string, int> occurrences)
        {
            List<string> result = new List<string>();
            foreach (KeyValuePair<string, int> word in occurrences)
            {
                if (word.Value % 2 == 1)
                {
                    result.Add(word.Key);
                }
            }

            return result.ToArray();
        }
    }
}
