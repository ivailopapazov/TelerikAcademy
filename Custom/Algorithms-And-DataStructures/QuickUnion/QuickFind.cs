namespace QuickUnion
{
    using System;

    public class QuickFind : IUnionFind
    {
        private int[] nodes;

        public QuickFind(int n)
        {
            this.nodes = new int[n];

            // Initialize identity array (every node is in it's own component)
            for (int i = 0; i < this.nodes.Length; i++)
            {
                this.nodes[i] = i;
            }
        }

        public bool Connected(int p, int q)
        {
            // Check if p and q are in the same component (nodes are connected)
            if (this.nodes[p] == this.nodes[q])
            {
                return true;
            }

            return false;
        }

        public void Union(int p, int q)
        {
            int pComponent = this.nodes[p];
            int qComponent = this.nodes[q];

            // Iterate the array and change every node from pComponent to qComponent
            for (int i = 0; i < this.nodes.Length; i++)
            {
                if (this.nodes[i] == pComponent)
                {
                    this.nodes[i] = qComponent;
                }
            }
        }

        /* Find method is really quick et the expense of the Union method.
         * Union method takes N^2 array accesses to process N union commands! <- Quadratic algorithms are too expensive. 
         * For 10 times bigger problems with 10 times faster computer, algorithm will work 10 times slower.
         * Quadratic algorithms doesn't scale with technology.
         */
    }
}
