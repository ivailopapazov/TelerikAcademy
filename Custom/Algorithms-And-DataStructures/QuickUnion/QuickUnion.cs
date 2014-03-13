namespace QuickUnion
{
    using System;
    using System.Linq;

    public class QuickUnion : IUnionFind
    {
        protected int[] nodes;

        public QuickUnion(int n)
        {
            this.nodes = new int[n];

            // Each node holds it's parent (initially every node is it's own parent or root)
            for (int i = 0; i < this.nodes.Length; i++)
            {
                nodes[i] = i;
            }
        }

        public virtual bool Connected(int p, int q)
        {
            if (this.Root(p) == this.Root(q))
            {
                return true;
            }

            return false;
        }

        public virtual void Union(int p, int q)
        {
            int pRoot = this.Root(p);
            int qRoot = this.Root(q);

            this.nodes[pRoot] = qRoot; 
        }

        protected virtual int Root(int node)
        {
            // Take the parent of the node
            int parent = this.nodes[node];

            // While parent is not the of the current tree
            while (parent != this.nodes[parent])
            {
                // Take the parent of the parent
                parent = this.nodes[parent];
            }

            // Return root (bash parent)
            return parent;
        }
        
        /* Union command in worst case is equal to QuickFind Union (if trees are tall)
         * Find is slower, but in total algorithm is faster.
         */
    }
}
