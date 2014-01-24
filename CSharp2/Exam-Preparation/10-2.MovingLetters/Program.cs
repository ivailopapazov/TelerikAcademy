using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://bgcoder.com/Contests/Submissions/View/295440

namespace _10_2.MovingLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            string[] words = Console.ReadLine().Split(' ');

            // Variables
            StringBuilder word = new StringBuilder();
            int length = 0;

            // Take longest length
            foreach (var w in words)
            {
                if (w.Length > length)
                {
                    length = w.Length;
                }
            }

            // Phase 1
            for (int i = 0; i < length; i++)
            {
                foreach (var w in words)
                {
                    if (i < w.Length)
                    {
                        word.Append(w[w.Length - 1 - i]);
                    }
                }
            }

            // Phase 2
            for (int i = 0; i < word.Length; i++)
            {
                int index = (char.ToLower(word[i]) - 'a' + 1 + i) % word.Length;
                char letter = word[i];
                word.Remove(i, 1);
                word.Insert(index, letter);
            }

            //print
            Console.WriteLine(word);
        }
    }
}
