namespace _2.AcademyTasks
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
            int[] pleasentness = Array.ConvertAll(Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);
            int variety = int.Parse(Console.ReadLine());

            int minIndex = 0;
            int maxIndex = 0;
            int min = int.MaxValue;
            int max = int.MinValue;
            for (int i = 0; i < pleasentness.Length; i++)
            {
                if (pleasentness[i] < min)
                {
                    min = pleasentness[i];
                    minIndex = i;
                }

                if (pleasentness[i] > max)
                {
                    max = pleasentness[i];
                    maxIndex = i;
                }

                if ((max - min) >= variety)
                {
                    var indexDiff = Math.Abs(maxIndex - minIndex);
                    var firstIndex = Math.Min(maxIndex, minIndex);
                    var dass = indexDiff / 2 + indexDiff % 2;
                    dass += firstIndex / 2 + firstIndex % 2;
                    dass++;

                    Console.WriteLine(dass);
                    return;
                }
            }

            Console.WriteLine(pleasentness.Length);
        }
    }
}
