using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.PrintSumAndAverageOfSequence
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

            int sum = CalculateSum(sequence);
            double average = CalculateAverage(sequence);

            Console.WriteLine("Sum = {0}", sum);
            Console.WriteLine("Average = {0}", average);
        }

        static int CalculateSum(IList<int> sequence)
        {
            int sum = 0;
            for (int i = 0; i < sequence.Count; i++)
			{
			    sum += sequence[i];
			}

            return sum;
        }

        static double CalculateAverage(IList<int> sequence)
        {
            int sum = CalculateSum(sequence);

            double average = sum / sequence.Count;

            return average;
        }
    }
}
