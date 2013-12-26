using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace combinatorics
{
    class Program
    {
        static void Main()
        {
            int k = 4;
            int n = 6;

            int[] elements = new int[k];
            Variations(elements, 0, n);
        }

        static void Variations(int[] arr, int index, int stop)
        {
            if (index >= arr.Length)
            {
                Console.WriteLine(string.Join(", ", arr));
            }
            else
            {
                for (int i = index; i < stop; i++)
                {
                    arr[index] = i + 1;
                    Variations(arr, index + 1, stop);
                }
            }
        }
    }
}
