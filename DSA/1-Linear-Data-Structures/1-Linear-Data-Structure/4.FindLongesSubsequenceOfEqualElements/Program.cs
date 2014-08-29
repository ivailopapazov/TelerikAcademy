using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.FindLongesSubsequenceOfEqualElements
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

            List<int> subSequence = FindLongestSubsequence(sequence);

            Console.WriteLine(string.Join(", ", subSequence));
        }

        static List<int> FindLongestSubsequence(List<int> sequence)
        {
            int maxLength = 0;
            int maxElement = sequence[0];
            int currentElement = sequence[0];
            int currentLength = 1;

            for (int i = 1; i < sequence.Count; i++)
            {
                currentElement = sequence[i];
                if (maxElement == currentElement)
                {
                    currentLength++;
                }
                else
                {
                    maxElement = currentElement;
                    currentLength = 1;
                }

                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                }
            }

            return new List<int>(Enumerable.Repeat(maxElement, maxLength));
        }
    }
}
