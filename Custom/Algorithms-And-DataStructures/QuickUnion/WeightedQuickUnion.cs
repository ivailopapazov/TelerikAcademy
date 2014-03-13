using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickUnion
{
    public class WeightedQuickUnion : QuickUnion, IUnionFind
    {
        protected int[] weights;

        public WeightedQuickUnion(int n)
            : base(n)
        {
            weights = new int[n];
        }

        public override void Union(int p, int q)
        {
            int pRoot = this.Root(p);
            int qRoot = this.Root(q);

            if (weights[pRoot] < weights[qRoot])
            {
                this.nodes[pRoot] = qRoot;
                this.weights[qRoot] += this.weights[pRoot];
            }
            else
            {
                this.nodes[qRoot] = pRoot;
                this.weights[pRoot] += this.weights[qRoot];
            }
        }
    }
}
