using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickUnion
{
    class Program
    {
        static void Main(string[] args)
        {
            var nodes = 100000;

            IList<IUnionFind> algorithms = new List<IUnionFind>()
            {
                new QuickFind(nodes),
                new QuickUnion(nodes),
                new WeightedQuickUnion(nodes),
                new WeightedQuickUnionWithPathCompression(nodes),
            };

            Console.WriteLine("Testing UnionFind algorithms with {0} nodes, {0} unions and {0} finds:", nodes);

            foreach (var algorithm in algorithms)
            {
                Console.WriteLine(TestUnionFind(algorithm, nodes));
            }
        }

        static string TestUnionFind(IUnionFind algorithm, int nodes)
        {
            Random rand = new Random();
            Stopwatch sw = new Stopwatch();
            StringBuilder result = new StringBuilder();

            sw.Start();
            // Make connections
            for (int i = 0; i < nodes; i++)
            {
                algorithm.Union(rand.Next(0, nodes), rand.Next(0, nodes));
            }
            sw.Stop();

            result.AppendFormat("{0} algorithm",algorithm.GetType().Name).AppendLine();
            result.AppendFormat("Union time elapsed: {0}", sw.Elapsed).AppendLine();

            sw.Reset();
            sw.Start();
            // Find connections
            for (int i = 0; i < nodes; i++)
            {
                algorithm.Connected(rand.Next(0, nodes), rand.Next(0, nodes));
            }
            sw.Stop();

            result.AppendFormat("Find time elapsed: {0}", sw.Elapsed);

            return result.ToString();
        }
    }
}
