using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.PrintSumAndAverageOfSequence
{
    class Sequences
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> sequence = new List<int>();

            while (input != String.Empty)
            {
                sequence.Add(int.Parse(input));
                input = Console.ReadLine();
            }

            int sum = CalculateSum(sequence);
            double average = CalculateAverage(sequence);

            Console.WriteLine("The sum of the sequence {{{0}}} is equal to {1}", String.Join(", ", sequence), sum);
            Console.WriteLine("The average is equal to {0}", average);
        }

        static double CalculateAverage(List<int> sequence) 
        {
            int sum = CalculateSum(sequence);

            double average = sum / sequence.Count;
            
            return average;
        }

        static int CalculateSum(List<int> sequence)
        {
            int sum = 0;

            for (int i = 0; i < sequence.Count; i++)
            {
                sum += sequence[i];
            }

            return sum;
        }
    }
}
