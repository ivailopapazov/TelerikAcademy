using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.PrintSortedList
{
    // 3.Write a program that reads a sequence of integers (List<int>) ending with an empty line and sorts them in an increasing order.
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

            sequence.Sort();
            Console.WriteLine(string.Join(", ", sequence));
        }
    }
}
