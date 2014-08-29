using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.SequenceReverser
{
    // 2.Write a program that reads N integers from the console and reverses them using a stack. Use the Stack<int> class.
    class SequenceReverser
    {
        static void Main(string[] args)
        {
            Stack<int> sequence = new Stack<int>();
            string entry = Console.ReadLine();
            while (entry != string.Empty)
            {
                sequence.Push(int.Parse(entry));
                entry = Console.ReadLine();
            }

            while (sequence.Count > 0)
            {
                Console.WriteLine(sequence.Pop());
            }
        }
    }
}
