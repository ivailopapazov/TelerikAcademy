using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.QueueSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            int N = int.Parse(Console.ReadLine());
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(N);
            List<int> resultSet = new List<int>();
            for (int i = 0; i < 50; i++)
            {
                int currentElement = queue.Dequeue();

                queue.Enqueue(currentElement + 1);
                queue.Enqueue(currentElement * 2 + 1);
                queue.Enqueue(currentElement + 2);

                resultSet.Add(currentElement);
            }

            Console.WriteLine(string.Join(", ", resultSet));
        }
    }
}
