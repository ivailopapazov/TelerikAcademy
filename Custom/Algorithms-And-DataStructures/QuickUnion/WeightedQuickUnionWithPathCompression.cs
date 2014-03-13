using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickUnion
{
    public class WeightedQuickUnionWithPathCompression : WeightedQuickUnion, IUnionFind
    {
        public WeightedQuickUnionWithPathCompression(int nodes)
            : base(nodes)
        {

        }

        // Find root with path compression
        protected override int Root(int node)
        {
            // Take the parent of the current node
            int parent = this.nodes[node];

            // While parent is not the root of the current tree
            while (parent != this.nodes[parent])
            {
                // Connect the current node to it's grandfather
                this.nodes[node] = this.nodes[parent];

                // Move the current node to parent
                node = parent;

                // Take the parent of the parent
                parent = this.nodes[parent];
            }

            // Return root (bash parent)
            return parent;
        }
    }
}
