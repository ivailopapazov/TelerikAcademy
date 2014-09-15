
    public class Node
    {
        private readonly IList<Edge> connections;

        public Node(int name)
        {
            this.Name = name;
            this.connections = new List<Edge>();
            this.IsHospital = false;
        }

        public int Name { get; private set; }
        public bool IsHospital { get; set; }

        public IEnumerable<Edge> Connections
        {
            get { return this.connections; }
        }

        public void AddConnection(Node targetNode, int distance, bool twoWay)
        {
            if (targetNode == null)
            {
                throw new ArgumentNullException("targetNode");
            }

            if (targetNode == this)
            {
                throw new ArgumentException("Node may not connect to itself.");
            }

            if (distance <= 0)
            {
                throw new ArgumentException("Distance must be positive.");
            }

            this.connections.Add(new Edge(targetNode, distance));

            if (twoWay)
            {
                targetNode.AddConnection(this, distance, false);
            }
        }

        public override string ToString()
        {
            return this.Name.ToString();
        }
    }

    public class Edge
    {
        public Edge(Node target, int distance)
        {
            this.Target = target;
            this.Distance = distance;
        }

        public Node Target { get; private set; }

        public int Distance { get; private set; }
    }

    public class Graph
    {
        public Graph()
        {
            this.Nodes = new Dictionary<int, Node>(); // Use string if name is string
        }

        public IDictionary<int, Node> Nodes { get; private set; }

        public void AddNode(int name)
        {
            var node = new Node(name);
            this.Nodes.Add(name, node);
        }

        public void AddConnection(int fromNode, int toNode, int distance, bool twoWay)
        {
            this.Nodes[fromNode].AddConnection(this.Nodes[toNode], distance, twoWay);
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            foreach (var node in this.Nodes)
            {
                result.Append(node.Key + " -> ");

                foreach (var connection in node.Value.Connections)
                {
                    result.Append(connection.Target + "-" + connection.Distance + " ");
                }

                result.AppendLine();
            }

            return result.ToString();
        }
    }

----------------- TEST ---------------------


public class GraphTest
{
    public static void Main()
    {
        var graph = new Graph();

        // Nodes
        graph.AddNode("A");
        graph.AddNode("B");
        graph.AddNode("C");
        graph.AddNode("D");
        graph.AddNode("E");
        graph.AddNode("F");
        graph.AddNode("G");
        graph.AddNode("H");
        graph.AddNode("I");
        graph.AddNode("J");
        graph.AddNode("Z");

        // Connections
        graph.AddConnection("A", "B", 14, true);
        graph.AddConnection("A", "C", 10, true);
        graph.AddConnection("A", "D", 14, true);
        graph.AddConnection("A", "E", 21, true);
        graph.AddConnection("B", "C", 9, true);
        graph.AddConnection("B", "E", 10, true);
        graph.AddConnection("B", "F", 14, true);
        graph.AddConnection("C", "D", 9, false);
        graph.AddConnection("D", "G", 10, false);
        graph.AddConnection("E", "H", 11, true);
        graph.AddConnection("F", "C", 10, false);
        graph.AddConnection("F", "H", 10, true);
        graph.AddConnection("F", "I", 9, true);
        graph.AddConnection("G", "F", 8, false);
        graph.AddConnection("G", "I", 9, true);
        graph.AddConnection("H", "J", 9, true);
        graph.AddConnection("I", "J", 10, true);

        // Print
        Console.WriteLine(graph.ToString());
    }
}