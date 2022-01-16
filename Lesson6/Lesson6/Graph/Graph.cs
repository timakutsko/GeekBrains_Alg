using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Graph
    {
        public List<Node> Nodes { get; }

        public Graph()
        {
            Nodes = new List<Node>();
        }
        
        public void AddNode(string nodeValue)
        {
            Nodes.Add(new Node(nodeValue));
        }
        
        public void AddEdge(string firstName, string secondName, int weight)
        {
            var v1 = FindNode(firstName);
            var v2 = FindNode(secondName);
            if (v2 != null && v1 != null)
            {
                v1.AddEdge(v2, weight);
                v2.AddEdge(v1, weight);
            }
        }

        private Node FindNode(string nodeValue)
        {
            foreach (var v in Nodes)
            {
                if (v.Value.Equals(nodeValue))
                {
                    return v;
                }
            }

            return null;
        }

        public void ResetIsChecker()
        {
            foreach(Node node in this.Nodes)
            {
                node.IsChecked = false;
            }
        }

        public void BFS_OrederTraves(string value)
        {
            var bfs_queue = new Queue<Node>();
            var startNode = FindNode(value);
            bfs_queue.Enqueue(startNode);

            while (bfs_queue.Count > 0)
            {
                var currentNode = bfs_queue.Dequeue();
                currentNode.IsChecked = true;
                var edges = currentNode.Edges;
                foreach(Edge edge in edges)
                {
                    if (!edge.Node.IsChecked && !bfs_queue.Contains(edge.Node))
                    {
                        bfs_queue.Enqueue(edge.Node);
                    }
                }
                Console.WriteLine(currentNode.Value);
            }
        }

        public void DFS_OrederTraves(string value)
        {
            var dfs_stack = new Stack<Node>();
            var startNode = FindNode(value);
            dfs_stack.Push(startNode);

            while (dfs_stack.Count > 0)
            {
                var currentNode = dfs_stack.Pop();
                currentNode.IsChecked = true;
                var edges = currentNode.Edges;
                foreach (Edge edge in edges)
                {
                    if (!edge.Node.IsChecked && !dfs_stack.Contains(edge.Node))
                    {
                        dfs_stack.Push(edge.Node);
                    }
                }
                Console.WriteLine(currentNode.Value);
            }
        }
    }
}
