using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.TextFileWordCounter
{
    class TextFileWordCounter
    {
        static string FilePath = "text.txt";

        static void Main(string[] args)
        {
            StreamReader textFile = new StreamReader(FilePath);
            List<string> words = new List<string>();
            using (textFile)
            {
                while (!textFile.EndOfStream)
                {
                    string line = textFile.ReadLine().ToLower();
                    char[] punctuation = new char[] { ',', '–', '-', '.', '!', '?', ' ' };
                    words.AddRange(line.Split(punctuation, StringSplitOptions.RemoveEmptyEntries));
                }
            }

            Dictionary<string, int> wordsOccurrences = CountWordsOccurrences(words);

            foreach (KeyValuePair<string, int> word in wordsOccurrences.OrderBy(w => w.Value))
            {
                Console.WriteLine("{0} -> {1}", word.Key, word.Value);
            }
        }

        static Dictionary<string, int> CountWordsOccurrences(IList<string> words)
        {
            Dictionary<string, int> wordOccurrences = new Dictionary<string,int>();
            foreach (string word in words)
            {
                if (!wordOccurrences.ContainsKey(word))
                {
                    wordOccurrences[word] = 0;
                }

                wordOccurrences[word]++;
            }

            return wordOccurrences;
        }
    }
}
