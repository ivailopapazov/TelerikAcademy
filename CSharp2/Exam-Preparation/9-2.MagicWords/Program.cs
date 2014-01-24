using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://bgcoder.com/Contests/Submissions/View/290511

namespace _9_2.MagicWords
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            int size = int.Parse(Console.ReadLine());
            List<string> words = new List<string>();

            for (int i = 0; i < size; i++)
            {
                words.Add(Console.ReadLine());
            }

            // Variables
            StringBuilder result = new StringBuilder();

            // Solution
            for (int i = 0; i < words.Count; i++)
            {
                int index = words[i].Length % (size + 1);
                words.Insert(index, words[i]);
                if (index < i)
                {
                    words.RemoveAt(i + 1);
                }
                else
                {
                    words.RemoveAt(i);
                }
         
            }

            int maxLength = words[0].Length;

            for (int i = 0; i < words.Count; i++)
			{
			    if (words[i].Length > maxLength)
                {
                    maxLength = words[i].Length;
                }
			}

            // print
            for (int i = 0; i < maxLength; i++)
            {
                foreach (var word in words)
                {
                    if (i < word.Length)
                    {
                        result.Append(word[i]);
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
