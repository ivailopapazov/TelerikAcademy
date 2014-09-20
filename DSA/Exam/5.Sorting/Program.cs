namespace _5.Sorting
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            var sequence = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int K = int.Parse(Console.ReadLine());
            bool isSorted = false;
            for (int i = 1; i < sequence.Length; i++)
            {
                if (sequence[i] < sequence[i - 1])
                {
                    var upperValue = K + i - 2;
                    for (int j = i - 1, k = 0; j < i + (K / 2); j++, k++)
                    {
                        var value = sequence[j];
                        sequence[j] = sequence[upperValue - k];
                        sequence[upperValue - k] = value;
                    }

                    isSorted = true;
                    break;
                }
            }

            if (isSorted)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(-1);
            }
        }
    }
}
